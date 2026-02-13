## Graphs and Charts

## Table of Figures
1. [Complete Class Diagram](#complete-class-diagram)
2. [Blazor Component Hierarchy](#blazor-component-hierarchy)
3. [Database Schema](#database-schema)
4. [Authentication Flow](#authentication-flow)
5. [Instance Creation Flow](#instance-creation-flow)
6. [LLM Integration Flow](#llm-integration-flow)
7. [Service Layer Architecture](#service-layer-architecture)

---

## Complete Class Diagram

```mermaid
classDiagram
       %% Model Classes
       class User {
           +int UserId PK
           +string FName
           +string LName
           +string CwuEmail UNIQUE
           +string Major
           +string Minor
           +int GraduationDate
           +string Password HASHED
       }

class Course {
    +int CourseId PK
    +string Title
    +string CourseDesc
    +List~Topic~ Topics
}

class Topic {
    +int TopicId PK
    +int CourseId FK
    +string Name
    +string TopicDesc
}

class Instance {
    +string InstanceId PK
    +int UserId FK
    +InstanceType Type
    +string Data JSON
    +LLM llm NotMapped
}

class InstanceType {
    <<enumeration>>
    Quiz
    Flash
    Tutor
}

class LLM {
    -Client client
    -string modelName
    -string fallbackPrompt
    -GenerateContentConfig initialModelConfig
    +LLM(InstanceType type)
    +AskAsync(string userMessage) Task~string~
    -initialPromptBuilder(InstanceType type) string
}

%% Service Classes
class DbService {
    -IDbContextFactory~StudyContext~ _contextFactory
    -PasswordHasher~User~ _passwordHasher
    +DbService(IDbContextFactory)
    +GetUserByEmailAsync(string email) Task~User~
    +GetUserByIdAsync(int userId) Task~User~
    +CreateUserAsync(User newUser) Task
    +IsEmailRegisteredAsync(string email) Task~bool~
    +SignInUserAsync(string email, string password) Task~User~
    +IsPasswordSameAsOldAsync(string email, string newPassword) Task~bool~
    +UpdateUserPasswordAsync(string email, string newPassword) Task
    +GetAllCoursesAsync() Task~List~Course~~
    +GetCourseNameByCourseIdAsync(int courseId) Task~string~
    +GetCourseDescriptionByCourseIdAsync(int courseId) Task~string~
    +GetTopicsByCourseIDAsync(int courseId) Task~List~Topic~~
    +GetTopicNamesByCourseIDAsnyc(int courseId) Task~List~string~~
    +SaveInstanceAsync(Instance instance) Task
    +GetInstanceByIdAsync(string instanceId) Task~Instance~
    +GetUserHistoryAsync(int userId) Task~List~Instance~~
}

class LLMService {
    +GenerateFlashCardDataValidatedJSONAsync(LLM, string, string, List~string~, string) Task~string~
    +GenerateQuizDataValidatedJSONAsync(LLM, string, string, List~string~, string) Task~string~
    +GenerateFlashCardDataListAsync(LLM, string, string, List~string~, string) Task~List~Tuple~string,string~~~
    +GenerateQuizDataListAsync(LLM, string, string, List~string~, string) Task~List~List~string~~~
    -GenerateFlashCardDataAsync(LLM, string, string, List~string~) Task~string~
    -GenerateFlashCardDataWithHistoryAsync(LLM, string, string, List~string~, string) Task~string~
    -GenerateQuizDataAsync(LLM, string, string, List~string~) Task~string~
    -GenerateQuizDataWithHistoryAsync(LLM, string, string, List~string~, string) Task~string~
    -validateJSON(string JSONRawOutput) string
}

class FlashcardData {
    +string keyword
    +string description
}

class QuizData {
    +string questionText
    +List~string~ options
    +string answer
}

class StudyContext {
    +DbSet~User~ Users
    +DbSet~Course~ Courses
    +DbSet~Topic~ Topics
    +DbSet~Instance~ Instances
    +StudyContext(DbContextOptions)
    #OnModelCreating(ModelBuilder modelBuilder)
}

%% Relationships
User "1" --> "*" Instance : owns
Course "1" --> "*" Topic : contains
Instance --> InstanceType : type
Instance --> LLM : uses

DbService ..> StudyContext : uses
DbService ..> User : manages
DbService ..> Course : queries
DbService ..> Topic : queries
DbService ..> Instance : saves/retrieves

LLMService ..> LLM : orchestrates
LLMService ..> FlashcardData : deserializes
LLMService ..> QuizData : deserializes

StudyContext --> User : manages
StudyContext --> Course : manages
StudyContext --> Topic : manages
StudyContext --> Instance : manages
```

---

## Blazor Component Hierarchy

```mermaid
graph TD 
App["App.razor<br/>Root Component"] 
App --> Routes["Routes"] 
Routes --> SignIn["SignIn.razor<br/>Route: /"] 
Routes --> CreateAccount["CreateAccount.razor<br/>Route: /create-account"] 
Routes --> ChangePassword["ChangePassword.razor<br/>Route: /change-password"] 
Routes --> Dashboard["Dashboard.razor<br/>Route: /dashboard"] 
Routes --> QuizMode["QuizMode.razor<br/>Route: /dashboard/quiz/:id"] 
Routes --> FlashMode["FlashMode.razor<br/>Route: /dashboard/flash/:id"] 
Routes --> TutorMode["TutorMode.razor<br/>Route: /dashboard/tutor/:id"]

%% Dashboard Components
Dashboard --> Sidebar1["Sidebar Component"]
Dashboard --> CourseOverview["CourseOverview Modal"]

CourseOverview --> TopicOverview["TopicOverview Modal"]

%% Study Mode Components
QuizMode --> Sidebar2["Sidebar Component"]
FlashMode --> Sidebar3["Sidebar Component"]
TutorMode --> Sidebar4["Sidebar Component"]

%% Injected Services
SignIn -.->|injects| DbSvc1["DbService"]
SignIn -.->|injects| NavMgr1["NavigationManager"]
SignIn -.->|injects| JS1["IJSRuntime"]

CreateAccount -.->|injects| DbSvc2["DbService"]
CreateAccount -.->|injects| NavMgr2["NavigationManager"]

ChangePassword -.->|injects| DbSvc3["DbService"]
ChangePassword -.->|injects| NavMgr3["NavigationManager"]

Dashboard -.->|injects| DbSvc4["DbService"]
Dashboard -.->|injects| NavMgr4["NavigationManager"]
Dashboard -.->|injects| JS2["IJSRuntime"]

CourseOverview -.->|injects| DbSvc5["DbService"]
CourseOverview -.->|injects| NavMgr5["NavigationManager"]
CourseOverview -.->|injects| JS3["IJSRuntime"]

TopicOverview -.->|injects| DbSvc6["DbService"]
TopicOverview -.->|injects| NavMgr6["NavigationManager"]
TopicOverview -.->|injects| JS4["IJSRuntime"]

Sidebar1 -.->|injects| DbSvc7["DbService"]
Sidebar1 -.->|injects| NavMgr7["NavigationManager"]
Sidebar1 -.->|injects| JS5["IJSRuntime"]

style App fill:#2196F3,color:#fff
style Dashboard fill:#4CAF50,color:#fff
style QuizMode fill:#FF9800,color:#fff
style FlashMode fill:#FF9800,color:#fff
style TutorMode fill:#FF9800,color:#fff
style CourseOverview fill:#9C27B0,color:#fff
style TopicOverview fill:#9C27B0,color:#fff
style Sidebar1 fill:#607D8B,color:#fff
```

---

## Database Schema
```mermaid
erDiagram USERS ||--o{ INSTANCES : "creates" COURSES ||--o{ TOPICS : "contains"

USERS {
    int UserId PK "Auto-increment"
    string FName "Max 45 chars"
    string LName "Max 45 chars"
    string CwuEmail UK "Max 100 chars, @cwu.edu"
    string Major "Max 45 chars"
    string Minor "Max 45 chars, Nullable"
    int GraduationDate "Year format"
    string Password "Max 255 chars, Hashed"
}

COURSES {
    int CourseId PK "Course number (e.g., 110)"
    string Title "Course name"
    string CourseDesc "Full description"
}

TOPICS {
    int TopicId PK "Auto-increment"
    int CourseId FK "References COURSES"
    string Name "Topic name"
    string TopicDesc "Topic description"
}

INSTANCES {
    string InstanceId PK "8-char GUID"
    int UserId FK "References USERS"
    string Type "Quiz, Flash, or Tutor"
    string Data "JSON format"
}


```

---

## Authentication Flow
```mermaid

sequenceDiagram
    actor User
    participant SignIn as SignIn.razor
    participant JS as IJSRuntime
    participant DbSvc as DbService
    participant DB as SQLite Database
    participant NavMgr as NavigationManager

User->>SignIn: Enter email & password
SignIn->>SignIn: Validate email format (@cwu.edu)
SignIn->>SignIn: Validate password rules

SignIn->>DbSvc: IsEmailRegisteredAsync(email)
DbSvc->>DB: Query Users table
DB-->>DbSvc: Email exists?
DbSvc-->>SignIn: bool result

alt Email not found
    SignIn-->>User: Show error: "Email not registered"
else Email found
    SignIn->>DbSvc: SignInUserAsync(email, password)
    DbSvc->>DB: Get user by email
    DB-->>DbSvc: User object
    DbSvc->>DbSvc: PasswordHasher.VerifyHashedPassword()
    
    alt Password invalid
        DbSvc-->>SignIn: null
        SignIn-->>User: Show error: "Invalid credentials"
    else Password valid
        DbSvc-->>SignIn: User object
        SignIn->>JS: localStorage.setItem("UserId", userId)
        JS-->>SignIn: Success
        SignIn->>NavMgr: NavigateTo("/dashboard")
        NavMgr-->>User: Redirect to Dashboard
    end
end
```
---

## Instance Creation Flow
```mermaid

sequenceDiagram 
    actor User 
    participant Dashboard as Dashboard.razor 
    participant CourseOv as CourseOverview.razor 
    participant TopicOv as TopicOverview.razor 
    participant JS as IJSRuntime 
    participant DbSvc as DbService 
    participant DB as SQLite Database 
    participant NavMgr as NavigationManager

User->>Dashboard: View courses
Dashboard->>DbSvc: GetAllCoursesAsync()
DbSvc->>DB: Query Courses with Topics
DB-->>DbSvc: List<Course>
DbSvc-->>Dashboard: courses
Dashboard-->>User: Display course cards

User->>Dashboard: Click course card
Dashboard->>Dashboard: Show CourseOverview modal

CourseOv->>DbSvc: GetTopicsByCourseIDAsync(courseId)
DbSvc->>DB: Query Topics
DB-->>DbSvc: List<Topic>
DbSvc-->>CourseOv: topics
CourseOv-->>User: Display course details & topics

alt User clicks Topic
    User->>CourseOv: Click topic
    CourseOv->>CourseOv: Show TopicOverview modal
    
    User->>TopicOv: Click study mode button (Quiz/Flash/Tutor)
    TopicOv->>JS: localStorage.getItem("UserId")
    JS-->>TopicOv: userId
    
    TopicOv->>TopicOv: Create Instance with topic data
    Note over TopicOv: Data = {courseId, topicId, topicName}
    
    TopicOv->>DbSvc: SaveInstanceAsync(instance)
    DbSvc->>DB: INSERT INTO Instances
    DB-->>DbSvc: Success
    DbSvc-->>TopicOv: Instance saved
    
    TopicOv->>NavMgr: NavigateTo("/dashboard/{mode}/{instanceId}")
    NavMgr-->>User: Redirect to study mode
    
else User clicks Course-level study mode
    User->>CourseOv: Click study mode button
    CourseOv->>JS: localStorage.getItem("UserId")
    JS-->>CourseOv: userId
    
    CourseOv->>CourseOv: Create Instance
    Note over CourseOv: Data = "{}" (empty JSON)
    
    CourseOv->>DbSvc: SaveInstanceAsync(instance)
    DbSvc->>DB: INSERT INTO Instances
    DB-->>DbSvc: Success
    DbSvc-->>CourseOv: Instance saved
    
    CourseOv->>NavMgr: NavigateTo("/dashboard/{mode}/{instanceId}")
    NavMgr-->>User: Redirect to study mode
end
```

---

## LLM Integration Flow
```mermaid
sequenceDiagram 
    actor User 
    participant StudyMode as Study Mode Page<br/>(Quiz/Flash/Tutor) 
    participant DbSvc as DbService 
    participant DB as SQLite Database 
    participant LLMSvc as LLMService 
    participant LLM as LLM Class participant Gemini as Google Gemini API

User->>StudyMode: Navigate with instanceId
StudyMode->>StudyMode: OnInitializedAsync()

StudyMode->>DbSvc: GetInstanceByIdAsync(instanceId)
DbSvc->>DB: Query Instances table
DB-->>DbSvc: Instance object
DbSvc-->>StudyMode: instance (with Data JSON)

StudyMode->>StudyMode: Parse instance.Data JSON
Note over StudyMode: Extract courseId, topicId, topicName

StudyMode->>DbSvc: GetCourseNameByCourseIdAsync(courseId)
DbSvc->>DB: Query Courses
DB-->>DbSvc: courseName
DbSvc-->>StudyMode: courseName

StudyMode->>DbSvc: GetCourseDescriptionByCourseIdAsync(courseId)
DbSvc->>DB: Query Courses
DB-->>DbSvc: courseDesc
DbSvc-->>StudyMode: courseDesc

StudyMode->>DbSvc: GetTopicNamesByCourseIDAsync(courseId)
DbSvc->>DB: Query Topics
DB-->>DbSvc: List<string> topicNames
DbSvc-->>StudyMode: topicNames

alt First time generation
    StudyMode->>LLM: new LLM(instance.Type)
    LLM->>LLM: initialPromptBuilder(type)
    Note over LLM: Creates specialized system prompt<br/>for Quiz/Flash/Tutor
    LLM-->>StudyMode: llm configured
    
    alt Quiz Mode
        StudyMode->>LLMSvc: GenerateQuizDataListAsync(llm, courseName, courseDesc, topicNames, null)
        LLMSvc->>LLMSvc: GenerateQuizDataAsync()
        LLMSvc->>LLM: AskAsync(prompt)
        LLM->>Gemini: GenerateContentAsync(prompt)
        Note over Gemini: Generate 12 multiple-choice<br/>questions in JSON format
        Gemini-->>LLM: JSON response
        LLM-->>LLMSvc: raw JSON string
        LLMSvc->>LLMSvc: validateJSON()
        Note over LLMSvc: Extract valid JSON<br/>using bracket matching
        LLMSvc->>LLMSvc: JsonSerializer.Deserialize<QuizData>()
        LLMSvc-->>StudyMode: List<List<string>> quizData
        StudyMode-->>User: Display questions
        
    else Flash Mode
        StudyMode->>LLMSvc: GenerateFlashCardDataListAsync(llm, courseName, courseDesc, topicNames, null)
        LLMSvc->>LLMSvc: GenerateFlashCardDataAsync()
        LLMSvc->>LLM: AskAsync(prompt)
        LLM->>Gemini: GenerateContentAsync(prompt)
        Note over Gemini: Generate 20 flashcards<br/>in JSON format
        Gemini-->>LLM: JSON response
        LLM-->>LLMSvc: raw JSON string
        LLMSvc->>LLMSvc: validateJSON()
        LLMSvc->>LLMSvc: JsonSerializer.Deserialize<FlashcardData>()
        LLMSvc-->>StudyMode: List<Tuple<string,string>> flashcards
        StudyMode-->>User: Display flashcards
        
    else Tutor Mode
        loop Chat interaction
            User->>StudyMode: Type question
            StudyMode->>LLM: AskAsync(userQuestion)
            LLM->>Gemini: GenerateContentAsync(question)
            Note over Gemini: Use Socratic method<br/>Guide student learning
            Gemini-->>LLM: Response text
            LLM-->>StudyMode: answer
            StudyMode-->>User: Display AI response
        end
    end
    
    StudyMode->>StudyMode: Update instance.Data with generated content
    StudyMode->>DbSvc: SaveInstanceAsync(instance)
    DbSvc->>DB: UPDATE Instances SET Data = newData
    DB-->>DbSvc: Success
    
else Regenerate with history
    StudyMode->>LLMSvc: Generate*WithHistoryAsync(..., instance.Data)
    Note over LLMSvc: Passes previous JSON to avoid duplicates
    LLMSvc->>LLM: AskAsync(prompt + history)
    LLM->>Gemini: GenerateContentAsync()
    Note over Gemini: Generate NEW content<br/>different from history
    Gemini-->>LLM: New JSON
    LLM-->>LLMSvc: raw JSON
    LLMSvc-->>StudyMode: new data
    StudyMode-->>User: Display fresh content
end


```

---

## Service Layer Architecture
```mermaid
graph TB 
    subgraph "Presentation Layer" 
    Pages["Blazor Pages<br/>SignIn, Dashboard, etc."] 
    Components["Blazor Components<br/>Sidebar, CourseOverview, etc."]    
end

subgraph "Service Layer"
    DbSvc["DbService<br/>Database Operations"]
    LLMSvc["LLMService<br/>AI Content Generation"]
    LLM["LLM Class<br/>Gemini API Wrapper"]
end

subgraph "Data Layer"
    Context["StudyContext<br/>EF Core DbContext"]
    SQLite[("SQLite Database<br/>studycat.db")]
end

subgraph "External Services"
    Gemini["Google Gemini API<br/>gemini-3-flash-preview"]
    LocalStorage["Browser localStorage<br/>Session Management"]
end

subgraph "Model Layer"
    Models["Domain Models<br/>User, Course, Topic, Instance"]
end

%% Connections
Pages --> DbSvc
Pages --> LLMSvc
Pages --> LocalStorage
Components --> DbSvc
Components --> LocalStorage

DbSvc --> Context
Context --> SQLite
DbSvc --> Models

LLMSvc --> LLM
LLM --> Gemini
LLMSvc --> Models

Context --> Models

style Pages fill:#2196F3,color:#fff
style Components fill:#2196F3,color:#fff
style DbSvc fill:#4CAF50,color:#fff
style LLMSvc fill:#4CAF50,color:#fff
style LLM fill:#FF9800,color:#fff
style Context fill:#9C27B0,color:#fff
style SQLite fill:#607D8B,color:#fff
style Gemini fill:#F44336,color:#fff
style LocalStorage fill:#FFC107,color:#000
style Models fill:#795548,color:#fff
```