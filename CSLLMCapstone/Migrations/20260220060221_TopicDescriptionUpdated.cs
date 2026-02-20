using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CSLLMCapstone.Migrations
{
    /// <inheritdoc />
    public partial class TopicDescriptionUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 385);

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1,
                column: "TopicDesc",
                value: "This module examines the dominant role of 'Big Tech' giants like Google, Apple, and Amazon in reshaping modern healthcare. Students will investigate how these corporations leverage massive consumer datasets to drive medical research and predictive health analytics. We will critically analyze the trade-offs between the convenience of integrated health ecosystems and the risks associated with data monopolization. The discussion extends to how corporate interests influence public health policy and the competitive landscape of medical innovation, questioning whether profit-driven tech firms can truly align with long-term patient wellness goals.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2,
                column: "TopicDesc",
                value: "Often dismissed as sedentary, video games are now recognized as powerful tools for physical and cognitive health. This topic explores the 'gamification' of fitness through exergaming and the use of specialized software for neurological rehabilitation. We will examine clinical studies on how gaming affects dopamine regulation, spatial awareness, and stress management. Conversely, the course addresses the risks of sedentary behavior and gaming disorder. Students will evaluate how immersive environments can provide distraction therapy for chronic pain patients and offer new frontiers in mental health resilience training.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3,
                column: "TopicDesc",
                value: "Telemedicine has transitioned from a niche convenience to a fundamental pillar of global healthcare infrastructure. This section explores the hardware and software enabling high-definition remote consultations and real-time patient monitoring. We will discuss the democratization of health access for rural and underserved populations, as well as the technical challenges of maintaining 'webside manner' through a screen. Students will analyze the regulatory hurdles, reimbursement models, and the critical importance of high-speed connectivity in ensuring that digital care delivery remains equitable and as effective as traditional in-person visits.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4,
                column: "TopicDesc",
                value: "Artificial Intelligence is revolutionizing diagnostics by processing medical imagery and genetic data with speeds unattainable by humans. This module covers the application of machine learning in identifying early-stage pathologies and personalizing treatment protocols. We will delve into the mechanics of neural networks in drug discovery and predictive modeling for disease outbreaks. However, we also confront the 'black box' problem—the difficulty of understanding how AI reaches its conclusions—and the potential for algorithmic bias to exacerbate existing health disparities if the training data is not representative.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Robotics", "Robotics in healthcare ranges from high-precision surgical systems like Da Vinci to autonomous hospital delivery droids. This topic focuses on how robotic assistance enhances human capabilities, reduces surgeon fatigue, and enables minimally invasive procedures with faster recovery times. Beyond the operating room, we explore social robotics designed for elder care and physical therapy. Students will study the engineering challenges of haptic feedback and the economic implications of integrating expensive robotic units into standard clinical workflows, weighing technological superiority against the high costs of implementation and maintenance." });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 6,
                column: "TopicDesc",
                value: "While often associated with illicit activity, the Deep Web plays a complex role in health data security and information exchange. This section investigates the infrastructure of non-indexed databases where sensitive electronic health records (EHR) are stored and protected. We will discuss the threats posed by the Dark Web, such as the black market for medical identities and stolen pharmaceutical data. Students will learn about the technologies used to anonymize data for medical research and the constant battle between cybersecurity professionals and those looking to exploit vulnerabilities in health networks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 7,
                column: "TopicDesc",
                value: "Virtual Reality (VR) offers immersive experiences that go far beyond entertainment, serving as a 'digital pharmacy' for psychological and physical ailments. This module explores VR’s efficacy in exposure therapy for PTSD, phobia desensitization, and acute pain management during painful medical procedures. We will examine how 3D simulations allow surgeons to practice complex operations in a risk-free environment. Students will analyze the physiological effects of immersion on the brain and the potential for VR to bridge the gap in empathy training for healthcare providers through perspective-taking simulations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 8,
                column: "TopicDesc",
                value: "Digital music technology provides innovative avenues for neurological recovery and emotional regulation. This topic examines the science of psychoacoustics and how algorithmic music generation can be tailored to individual heart rates and brainwave patterns to reduce anxiety. We will look at software used in speech therapy and motor skill rehabilitation for stroke survivors. Students will explore the intersection of creative coding and clinical therapy, evaluating how MIDI interfaces and digital audio workstations enable patients with limited mobility to engage in therapeutic expression and cognitive exercises.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 9,
                column: "TopicDesc",
                value: "The rise of wearable devices has shifted health monitoring from the doctor's office to the user's wrist. This section analyzes the sensors used to track heart rate variability, blood oxygen levels, and sleep architecture. We will discuss the shift toward preventative medicine, where continuous data streams allow for the early detection of arrhythmias or respiratory distress. Students will also grapple with the 'quantified self' movement, looking at the psychological impact of constant monitoring and the technical challenges of ensuring data accuracy and interoperability across different device platforms.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 10,
                column: "TopicDesc",
                value: "As technology outpaces legislation, ethical frameworks become essential in guiding health innovation. This concluding module addresses the moral implications of genetic engineering, AI-driven triage, and the 'digital divide' that leaves behind those without tech literacy. We will debate the ownership of biological data and the rights of patients in an era of automated decision-making. Students are challenged to develop a critical lens on equity, asking who benefits from these technologies and who is at risk of being marginalized, ensuring that future health-tech developments prioritize human dignity and social justice.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 11,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Visual Basic Fundamentals", "This module introduces students to the core syntax and structure of Visual Basic as a gateway to object-oriented programming. We focus on the foundational elements of the language, including variable declaration, data types, and control structures like loops and conditional statements. By mastering these basics, students begin to see how high-level code translates human intent into machine-executable instructions. The curriculum emphasizes writing clean, readable code that serves as the primary tool for expressing complex mathematical logic and building functional applications from the ground up." });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 12,
                column: "TopicDesc",
                value: "At the heart of every program lies a rigorous framework of Boolean algebra and discrete mathematics. This topic explores the essential connection between mathematical truth and computational state. Students will delve into truth tables, logical operators (AND, OR, NOT), and the binary numbering system that forms the bedrock of digital processing. By understanding these principles, learners can construct more efficient code and develop a deeper appreciation for how abstract symbols and logic gates allow computers to perform sophisticated calculations and make autonomous decisions based on predefined conditions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 13,
                column: "TopicDesc",
                value: "Quantitative reasoning in computing involves the ability to interpret, analyze, and manipulate numerical data through programmatic means. This module challenges students to apply mathematical models to solve real-world problems, such as financial forecasting or statistical analysis. We focus on developing a mindset that looks beyond the surface of a problem to identify the underlying numerical patterns. Students will learn to use programming as a calculator for complex variables, ensuring they can validate their results and understand the significance of data-driven conclusions in a digital environment.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 14,
                column: "TopicDesc",
                value: "Technology does not exist in a vacuum; its evolution carries profound societal consequences. This section examines the 'Digital Revolution' through a critical lens, discussing how automation affects the workforce and how algorithmic bias can impact social equity. We explore the ethical responsibilities of developers regarding user privacy, digital surveillance, and the environmental footprint of global computing infrastructure. Students will engage in debates about the political power of big data and the importance of creating inclusive technology that prioritizes human rights and ethical integrity alongside technical efficiency.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 15,
                column: "TopicDesc",
                value: "This advanced topic introduces students to the concepts of data structures and the efficiency of parallel processing. We explore how data can be associated through mapping techniques that allow for high-speed retrieval and organization. The module covers the logic of 'MapReduce' frameworks and how breaking down large datasets into parallel tasks can significantly decrease computation time. By understanding these mapping associations, students learn to design programs that are scalable and capable of handling the massive data loads characteristic of modern enterprise computing and scientific research.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 16,
                column: "TopicDesc",
                value: "Computational thinking is a universal problem-solving process that involves decomposition, pattern recognition, and abstraction. This module teaches students how to break down a daunting, complex problem into smaller, manageable parts that a computer can solve. We focus on identifying which aspects of a problem are relevant and which can be ignored through abstraction. This mental framework is not just for programmers; it is a vital skill for any discipline that requires systematic analysis and the ability to design reproducible solutions for intricate challenges.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 17,
                column: "TopicDesc",
                value: "An algorithm is only as effective as its sequence of operations. This topic focuses on the vital importance of order and flow in programming. Students will learn to design step-by-step instructions that lead to a predictable and correct outcome, exploring how slight changes in sequencing can result in vastly different performance results. We cover the design of flowcharts and pseudocode to map out logic before implementation. Mastery of sequencing allows students to create sophisticated programs that handle complex branching and recursive tasks with precision and mathematical reliability.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 18,
                column: "TopicDesc",
                value: "Modern software development relies on powerful tools designed to streamline the coding process. This module introduces students to the Integrated Development Environment (IDE), focusing on features like syntax highlighting, IntelliSense, and integrated debugging tools. Students will learn how to navigate the workspace, manage project files, and use the debugger to step through code to find and fix errors. Becoming proficient in an IDE allows students to focus less on the mechanics of typing and more on the creative and logical aspects of problem-solving.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 19,
                column: "TopicDesc",
                value: "This module introduces the Unreal Engine 4 architecture, focusing on the core principles of software development within a high-performance game engine. Students will explore the relationship between Java-based logic and the engine's internal systems, learning to navigate the editor, manage assets, and understand the deployment pipeline. We emphasize the full software lifecycle, from requirement specification to final execution. By mastering these fundamentals, students build a technical foundation that allows them to turn abstract programming concepts into functional, real-time interactive environments while adhering to industry-standard software engineering practices.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 20,
                column: "TopicDesc",
                value: "Every successful game is composed of interconnected systems including mechanics, dynamics, and aesthetics. This topic breaks down the essential components that define the player experience, such as feedback loops, win/loss conditions, and resource management. Students will analyze how simple rules can lead to complex emergent gameplay. By identifying these core elements, learners can approach game creation as a structured engineering problem, ensuring that every feature serves a specific purpose in the broader software architecture and contributes to a cohesive and engaging user experience.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 21,
                column: "TopicDesc",
                value: "Game design is the bridge between technical software development and creative expression. This section focuses on the iterative design process, where students draft technical specifications and gameplay loops before writing a single line of code. We cover the importance of balance, difficulty scaling, and player agency. Students will learn to document their design choices in a Game Design Document (GDD), which serves as the blueprint for the entire development team. This structured approach ensures that the project remains scoped and technically feasible throughout the production lifecycle.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 22,
                column: "TopicDesc",
                value: "Innovation begins with structured brainstorming techniques designed to generate and vet unique game concepts. This module teaches students how to use mind mapping, 'what-if' scenarios, and rapid prototyping to explore diverse ideas. We emphasize the importance of identifying a 'core hook' that distinguishes their software from existing titles. Students will learn to evaluate their ideas against technical constraints, ensuring that the final selected concept is both creative and achievable within the Unreal Engine framework, balancing blue-sky thinking with the realities of software maintenance and hardware performance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 23,
                column: "TopicDesc",
                value: "A compelling narrative provides the context that drives player motivation. This topic explores the techniques used to weave backstory and world-building into the gameplay experience. Students will learn how to create lore that justifies game mechanics and environmental storytelling that rewards exploration. We analyze the difference between linear and branching narratives, and how software variables can be used to track player choices that alter the story's outcome. The goal is to create a rich, immersive world that feels consistent and deeply connected to the player's actions within the game.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 24,
                column: "TopicDesc",
                value: "In game development, a scenario defines the specific circumstances or missions a player encounters. This module covers the creation of level-specific goals and the logic required to trigger events within Unreal Engine. Students will learn to script scenarios that test player skills and advance the narrative. We focus on 'pacing'—the ebb and flow of tension and action—to prevent player fatigue. By designing well-structured scenarios, students learn to manage complex state changes in their code, ensuring that the software responds accurately to a wide variety of player inputs and environmental triggers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 25,
                column: "TopicDesc",
                value: "Storyboarding and scripting provide the visual and textual roadmap for cinematic sequences and character dialogue. This section introduces students to visual communication tools that help plan the camera angles and timing of in-game cutscenes. We also cover scriptwriting for interactive dialogue, where logic branches are used to handle different player responses. This phase of development is crucial for identifying potential technical bottlenecks early, allowing the developer to visualize the user flow and ensure that the narrative transitions smoothly into active gameplay without breaking immersion.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 26,
                column: "TopicDesc",
                value: "Great software must be usable by everyone, regardless of physical or cognitive ability. This topic focuses on UI/UX design principles and accessibility standards in gaming, such as colorblind modes, rebindable keys, and screen reader compatibility. Students will conduct usability testing to identify friction points in their interface and controls. We emphasize that accessibility is not an 'add-on' but a fundamental part of the software requirement specification. By prioritizing inclusive design, students ensure their games are enjoyable for the widest possible audience while meeting modern legal and ethical standards.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 27,
                column: "TopicDesc",
                value: "This module addresses the complex landscape of digital rights, monetization ethics, and online safety. Students will investigate the legalities of Intellectual Property (IP) and licensing in Unreal Engine development. We discuss controversial topics like 'loot boxes,' dark patterns in game design, and the social impact of toxic online communities. By evaluating these issues, students learn to navigate the responsibilities of being a developer in a global market, ensuring their software respects user privacy and promotes a healthy, ethical gaming environment that avoids predatory practices or legal pitfalls.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 28,
                column: "TopicDesc",
                value: "Beyond entertainment, game mechanics are increasingly used to solve real-world problems in education and corporate training. This section explores 'gamification'—applying game elements like points, badges, and leaderboards to non-game contexts. Students will study the psychology of motivation and how game-based learning can improve information retention and engagement. We will analyze successful case studies in medical and educational software, challenging students to think about how their programming skills can be used to create tools that educate, train, and inspire users through interactive challenges and rewarding progression systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 29,
                column: "TopicDesc",
                value: "Gaming science delves into the physiological and psychological effects of interactive media on the human brain. This topic explores 'flow state,' dopamine response, and the cognitive load involved in complex problem-solving. Students will learn how to use data analytics to track player behavior and optimize gameplay balance. We also investigate the science of procedural generation, where mathematical algorithms are used to create infinite game worlds. Understanding these scientific principles allows developers to create more effective feedback loops and deeply satisfying interactions that align with how humans process information and rewards.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 30,
                column: "TopicDesc",
                value: "Understanding where the industry has been is vital for predicting where it is going. This module traces the evolution of gaming from early mainframe experiments to the multi-billion dollar industry of today. We examine how hardware advancements, from 8-bit processors to modern GPUs, have dictated the scope of software development. Students will analyze the history of genre innovation and the cultural shifts that allowed gaming to become a dominant form of global media. This historical perspective provides context for current design trends and helps students avoid repeating past technical and creative mistakes.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 31,
                column: "TopicDesc",
                value: "The gaming industry offers a vast array of career paths, from gameplay programming and technical art to project management and quality assurance. This section provides a realistic look at the professional landscape, discussing the roles within 'AAA' studios versus independent 'Indie' development. Students will learn about the skills required for different specialties and the importance of building a professional portfolio. We also touch on the business side of gaming, including marketing, publishing, and community management, helping students identify where their specific interests and programming talents fit best within the global ecosystem.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 32,
                column: "TopicDesc",
                value: "The future of gaming lies at the intersection of emerging technologies like cloud computing, artificial intelligence, and extended reality (XR). This topic explores how 5G and edge computing will enable more complex, persistent online worlds. We discuss the potential for AI-driven NPCs that offer truly organic interactions and the shift toward the 'Metaverse'—a unified digital reality. Students will evaluate how these advancements will change the way software is developed and consumed, preparing them to adapt to a rapidly evolving industry where the boundaries between the physical and digital worlds continue to blur.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 33,
                column: "TopicDesc",
                value: "Gaming has birthed diverse subcultures, from professional eSports athletes to the vibrant modding community. This concluding module examines how these communities influence game development and longevity. We explore how 'modding' (modifying game code) acts as a training ground for future developers and how streaming platforms like Twitch have changed the way games are marketed and played. Students will learn the importance of fostering a community around their software and how subcultures can drive innovation, provide bug reports, and extend the lifecycle of a product through user-generated content and social interaction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 34,
                column: "TopicDesc",
                value: "This introductory module establishes the core programming skills necessary for data analysis. Students will master Python syntax, including dynamic typing, list comprehensions, and control flow. We focus on the data structures most relevant to quantitative reasoning, such as dictionaries and tuples, and how to write modular code using functions. By the end of this section, students will be comfortable navigating the Python environment and writing scripts that automate basic data manipulation tasks, providing the foundational literacy required to tackle the more advanced statistical programming modules that follow in the curriculum.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 35,
                column: "TopicDesc",
                value: "Effective data visualization is the key to transforming raw numbers into actionable insights. In this module, students use libraries like Matplotlib and Seaborn to generate professional-grade histograms, scatter plots, and box-and-whisker diagrams. We explore the principles of visual integrity—learning how to choose the right chart type to represent specific data relationships without distortion. Beyond simply writing code to render plots, students practice interpreting these visual forms to identify trends, outliers, and patterns that are often invisible in raw datasets, bridging the gap between computational output and human understanding.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 36,
                column: "TopicDesc",
                value: "Object-Oriented Programming (OOP) allows students to build complex simulations by organizing code into reusable 'objects.' This section covers the creation of classes, methods, and inheritance in Python. Students will learn to model real-world entities—such as a 'Patient' or a 'Statistical Trial'—as objects that carry their own data and behaviors. This structural approach is essential for managing larger codebases and creating sophisticated quantitative tools. By mastering encapsulation and abstraction, learners can develop more robust, scalable, and maintainable programs that mirror the complexity of the systems they are analyzing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 37,
                column: "TopicDesc",
                value: "Stochastic programming introduces the element of randomness into computational models. Unlike deterministic programs, stochastic models yield different results across multiple runs, reflecting the unpredictability of the real world. Students will learn to use Python’s random number generators to build Monte Carlo simulations and random walks. This module is critical for understanding how to model uncertainty in fields like finance, physics, or biology. Students will evaluate how running a simulation thousands of times can provide a distribution of possible outcomes, allowing for more nuanced decision-making under conditions of risk and variability.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 38,
                column: "TopicDesc",
                value: "This topic explores the mathematical laws governing random events and how they are implemented in Python. Students will study various probability distributions, including Normal, Binomial, and Uniform distributions, and learn how to characterize them using mean, variance, and standard deviation. By using the SciPy library, students can calculate the likelihood of specific outcomes and visualize how data clusters around central tendencies. Understanding these distributions is vital for making predictions and forms the theoretical backbone for all subsequent statistical inference and hypothesis testing performed in the course.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 39,
                column: "TopicDesc",
                value: "Since we rarely have access to entire populations, we must rely on samples to draw conclusions. This module teaches students how to perform random sampling in Python and calculate the 'Confidence Interval'—the range within which the true population parameter likely falls. We explore the Central Limit Theorem and how sample size affects the margin of error. Students will learn to interpret p-values and confidence levels, gaining the critical thinking skills to judge the reliability of a dataset and understand the degree of certainty associated with their statistical claims.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 40,
                column: "TopicDesc",
                value: "Working with real-world experimental data requires a different set of skills than working with 'clean' textbook examples. This module focuses on data cleaning, handling missing values, and performing regression analysis to find correlations between variables. Students will learn to use the 'least squares' method to fit lines to data points and evaluate the 'goodness of fit.' We emphasize the distinction between correlation and causation, teaching students to be skeptical of data patterns and to look for confounding variables that might skew the results of their experiments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 41,
                column: "TopicDesc",
                value: "Hypothesis checking is the formal process of using statistics to determine if a result is significant or merely due to chance. Students will learn to frame null and alternative hypotheses and use Python to perform t-tests and ANOVA. We discuss the risks of Type I and Type II errors—false positives and false negatives—and the importance of statistical power. This module empowers students to move beyond anecdotal evidence, providing them with a rigorous, programmable framework for validating scientific claims and making objective, evidence-based conclusions in any data-driven field.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 42,
                column: "TopicDesc",
                value: "The final module introduces Bayesian inference, a method where probability is updated as more evidence becomes available. Students will explore Bayes' Theorem and its applications in machine learning and medical diagnostics. Unlike frequentist statistics, the Bayesian approach allows for the integration of prior knowledge into the model. Using Python, students will calculate conditional probabilities to solve complex problems, such as the likelihood of a disease given a positive test result. This advanced perspective encourages a flexible, iterative approach to reasoning that is highly valued in modern data science and artificial intelligence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 43,
                column: "TopicDesc",
                value: "This module introduces students to the Java development environment and the fundamental syntax of the language. Students will learn about the Java Virtual Machine (JVM), the importance of platform independence, and the basic structure of a Java class. We focus on primitive data types, arithmetic operators, and the strict typing system that makes Java a robust language for beginners. By the end of this section, students will be able to write, compile, and execute simple sequential programs that perform basic calculations and handle user input and output through the console.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 44,
                column: "TopicDesc",
                value: "Programming is rarely linear; it requires the ability to make choices based on data. This topic explores Boolean logic and the implementation of decision-making constructs like if-else statements and switch blocks. Students will learn how to evaluate complex conditions using logical operators and nested decisions to control the flow of execution. Understanding these structures is vital for creating interactive software that can respond dynamically to different user inputs or environmental states, ensuring the program can handle multiple scenarios with precision and reliability.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 45,
                column: "TopicDesc",
                value: "While often associated with enterprise software, Java remains a significant language in the gaming industry, particularly for mobile and backend server development. This module explores how mastering Java's memory management and object-oriented principles prepares students for careers in game programming. We discuss roles such as gameplay engineer, systems architect, and tools developer. Students will analyze how the logic learned in this course applies to game physics and UI systems, illustrating how a strong foundation in a versatile language like Java opens doors to both the massive gaming market and broader tech sectors.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 46,
                column: "TopicDesc",
                value: "Automation is a core strength of computing, achieved through repetition constructs. This section covers the logic and implementation of while, do-while, and for loops. Students will practice managing loop control variables and avoiding common pitfalls like infinite loops. We also delve into nested loops, which are essential for processing multi-dimensional data or creating complex patterns. Mastery of these constructs allows students to handle large-scale tasks—such as iterating through thousands of records or maintaining a game loop—with just a few lines of efficient, reusable code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 47,
                column: "TopicDesc",
                value: "Modularization is the practice of breaking large, complex programs into smaller, manageable pieces called methods. In this module, students learn to write reusable blocks of code that perform specific tasks, exploring concepts like parameter passing, return types, and variable scope. We emphasize the 'Don't Repeat Yourself' (DRY) principle, showing how methods improve code readability and maintainability. By learning to modularize their logic, students transition from writing single-file scripts to designing organized systems where code can be easily tested, debugged, and shared across different parts of an application.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 48,
                column: "TopicDesc",
                value: "Classes serve as the blueprints for objects, defining the data and behaviors that make up a software entity. This topic introduces students to the structure of a class, including fields (attributes) and methods (behaviors). Students will learn to write their own custom classes, manage access modifiers like public and private, and use constructors to initialize new objects. This marks the beginning of professional-grade software design, where students learn to encapsulate data and logic, creating a clear separation of concerns that is essential for building complex, error-resistant applications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 49,
                column: "TopicDesc",
                value: "Object-Oriented Programming (OOP) is a paradigm that models software after real-world objects. This module explores the core pillars of OOP: encapsulation, abstraction, and the relationship between classes and objects. Students will learn how to instantiate objects from their classes and manipulate them within a program. We focus on the benefits of this approach, such as code reusability and the ability to manage complex data relationships. Understanding OOP is critical for modern software development, as it provides a framework for building large-scale systems that are intuitive to design and easy to extend over time.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 50,
                column: "TopicDesc",
                value: "Data management often requires handling collections of items rather than single values. This section covers fixed-size arrays and the dynamic ArrayList class. Students will learn to store, access, and modify elements within these collections, using loops to iterate through data efficiently. We compare the performance and flexibility of standard arrays versus the built-in methods provided by the ArrayList class, such as adding, removing, and searching for items. Mastering these collection types is essential for any program that handles lists of users, inventory items, or any set of repetitive data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 51,
                column: "TopicDesc",
                value: "This module explores the 'static' keyword and its role in memory management. Students learn how static members belong to the class itself rather than individual instances, making them ideal for shared constants and utility functions. We discuss the lifecycle of static data and the limitations of static methods, such as their inability to access non-static instance variables. This understanding is crucial for designing efficient applications that manage global states or provide common services across multiple objects without unnecessary memory overhead.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 52,
                column: "TopicDesc",
                value: "Advanced methods often need to move entire data structures around an application. This topic teaches students how to return object references from methods, enabling the creation of 'factory' patterns and modular object generation. We emphasize the importance of reference handling, ensuring students understand that they are returning a pointer to the memory location of the object. This skill is foundational for building complex systems where different modules must collaborate by exchanging high-level data structures rather than just primitive values.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 53,
                column: "TopicDesc",
                value: "The toString method is a vital debugging and logging tool in the Java ecosystem. Students learn to override the default Object implementation to provide meaningful, human-readable representations of their data structures. We discuss how this method is implicitly called during string concatenation and printing. Mastering the design of clear, concise string outputs helps developers monitor program state in real-time and simplifies the process of communicating object data to users or log files throughout the development lifecycle.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 54,
                column: "TopicDesc",
                value: "In Java, using the '==' operator on objects only compares memory addresses, not content. This section focuses on implementing the .equals() method and the Comparable interface to perform logical comparisons. Students learn how to define what makes two objects 'equal' based on their internal attributes. This is essential for sorting algorithms, searching through collections, and ensuring data integrity within databases or lists, where the logical identity of a business object is more important than its physical location in RAM.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 55,
                column: "TopicDesc",
                value: "Aggregation represents a 'has-a' relationship between classes, where one object acts as a container for others. This module explores how to compose complex systems by combining simpler objects—such as a 'Course' object containing a 'Professor' object. Students learn to manage these relationships without creating tight coupling, ensuring that the lifecycle of the contained object can exist independently. This structural technique is key to building scalable, modular software that mirrors the hierarchical relationships found in the real world.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 56,
                column: "TopicDesc",
                value: "To prevent unintended side effects when passing objects, developers must often create independent duplicates. This topic introduces the copy constructor as a standard way to perform 'deep copies' of objects. Students learn how to manually copy each field, including references to other objects, to ensure that modifying the duplicate does not alter the original. This practice is critical for maintaining data encapsulation and preventing 'security leaks' or logic errors in complex applications where multiple components share access to the same data types.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 57,
                column: "TopicDesc",
                value: "The 'null' reference is a common source of runtime crashes in Java. This section teaches students how to safely handle uninitialized object variables and avoid the dreaded NullPointerException. We cover defensive programming techniques, such as null checks and the use of the Optional class. Understanding nullability helps students write more resilient code that gracefully handles missing data or failed object lookups, ensuring that the application remains stable even when encountering unexpected or incomplete data states during execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 58,
                column: "TopicDesc",
                value: "Enumerated types (Enums) allow developers to define a restricted set of named constants, improving code readability and type safety. This module explores how Enums in Java are more than just integers; they are specialized classes that can have fields and methods. Students learn to use Enums to represent fixed categories, such as days of the week or transaction statuses. By replacing 'magic numbers' with descriptive Enum values, students create code that is easier to maintain, less prone to input errors, and self-documenting for other developers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 59,
                column: "TopicDesc",
                value: "String objects in Java are immutable, meaning frequent modifications can lead to significant memory fragmentation. This topic introduces the StringBuilder class as a high-performance alternative for intensive string manipulation. Students learn how StringBuilder uses a mutable buffer to append, insert, and delete characters without creating new objects in memory. This is a critical optimization skill for applications that process large amounts of text data, generate complex reports, or handle high-frequency user input in a resource-efficient manner.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 60,
                column: "TopicDesc",
                value: "Tokenizing is the process of breaking a string into smaller, meaningful pieces based on delimiters like commas or spaces. This module covers the use of the String.split() method and the StringTokenizer class. Students learn to parse raw data from files or user input, converting unstructured text into usable program variables. This skill is vital for processing CSV files, interpreting command-line arguments, and building the initial stages of compilers or data-import tools where raw text must be transformed into structured object data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 61,
                column: "TopicDesc",
                value: "Inheritance is a cornerstone of Object-Oriented Programming that establishes a 'is-a' relationship between classes. Students learn how a 'subclass' can inherit fields and methods from a 'superclass,' promoting massive code reuse and organizational clarity. We explore how to extend existing functionality to create specialized versions of a class. This module emphasizes the hierarchical nature of software design, showing students how to build a broad base of common functionality and then refine it into specific implementations without duplicating logic across the codebase.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 62,
                column: "TopicDesc",
                value: "Focusing on the top of the inheritance tree, this topic explains the role of the superclass in defining a common interface for all descendants. Students learn to use the 'super' keyword to call parent constructors and methods, ensuring that the foundational state of an object is correctly initialized. We discuss the Object class as the ultimate superclass in Java. Understanding superclasses allows developers to write generalized code that can operate on any subclass, making the software more flexible and easier to update as new features are added.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 63,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Overriding", "Method overriding allows a subclass to provide a specific implementation for a method already defined in its superclass. Students learn to use the @Override annotation to modify inherited behaviors, such as a 'Square' class providing its own 'calculateArea' logic. We distinguish between overriding (different classes, same signature) and overloading (same class, different signature). This capability is essential for implementing specialized logic while maintaining a consistent method interface across a class hierarchy, enabling the software to behave differently based on the specific object type." });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 64,
                column: "TopicDesc",
                value: "Access control is vital in class hierarchies. This module introduces the 'protected' modifier, which allows variables and methods to be accessible within the same package and by subclasses in other packages. Students learn to balance data security with inheritance needs, hiding implementation details from the outside world while still allowing child classes to interact with parent data. This nuanced approach to encapsulation ensures that the internal workings of a class are protected while still providing the necessary hooks for extension and specialization.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 65,
                column: "TopicDesc",
                value: "Real-world software often uses multi-level inheritance, where a class inherits from a subclass, creating a chain. Students explore how data and methods trickle down through multiple layers of specialization. We discuss the order of constructor execution in an inheritance chain and the potential complexities of deep hierarchies. By understanding these chains, students learn to design deep but manageable logical structures, ensuring that shared traits are kept as high as possible in the tree to maximize reuse and simplify global updates to system behavior.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 66,
                column: "TopicDesc",
                value: "Polymorphism is the ability of an object to take on many forms. This module teaches students how a superclass reference can point to a subclass object, allowing for dynamic method binding at runtime. We explore how this allows developers to write code that works with a general type (like 'Shape') but performs the specific actions of a concrete type (like 'Circle' or 'Rectangle'). Polymorphism is the key to creating scalable systems where new types of objects can be added with minimal changes to the existing logic.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 67,
                column: "TopicDesc",
                value: "Abstract classes serve as incomplete templates that cannot be instantiated on their own. Students learn to use the 'abstract' keyword to define methods that subclasses MUST implement. This provides a way to enforce a specific contract or interface across different objects while providing some shared functionality. We discuss the difference between abstract classes and interfaces, helping students decide when to use a rigid template versus a flexible capability. Abstract classes are essential for designing large frameworks where certain behaviors are guaranteed but left for final implementation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 68,
                column: "TopicDesc",
                value: "Exceptions are Java's way of signaling that something has gone wrong during execution. This section covers the exception hierarchy, distinguishing between checked and unchecked exceptions. Students learn the 'try-catch' block and the importance of the 'finally' clause for resource cleanup. By understanding how to throw and catch exceptions, developers can prevent their applications from crashing when encountering file errors, network issues, or invalid user input. This module shifts the focus from writing 'happy path' code to building resilient, professional-grade software that handles failure gracefully.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 69,
                column: "TopicDesc",
                value: "Beyond simple try-catch blocks, professional error handling involves strategic logging and user feedback. This module teaches students how to create custom exception classes to represent domain-specific errors. We discuss the 'bubble-up' effect, where errors are passed to higher levels of the application to be handled by a centralized controller. Students learn to provide meaningful error messages to users while keeping technical stack traces in the background. Mastering these techniques ensures that even when a critical error occurs, the user experience remains controlled and the developers have the data needed to fix the issue.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 70,
                column: "TopicDesc",
                value: "Advanced File Input/Output moves beyond basic text files into more efficient and complex storage methods. Students learn to work with streams and readers to handle large volumes of data. We explore the use of buffered I/O to improve performance and the importance of properly closing resources to prevent memory leaks. This module provides the tools for building applications that can save and load complex program states, interact with external data sources, and manage local storage in a way that is robust against power failures or data corruption.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 71,
                column: "TopicDesc",
                value: "Binary files store data in the machine's native format, making them faster and more compact than text files. Students learn to use DataOutputStream and DataInputStream to write and read primitive data types directly. We discuss the advantages of binary storage for performance-critical applications like games or high-speed data loggers. Because binary data is not human-readable, students also learn the importance of documenting file formats and ensuring that the data is read in the exact order it was written to maintain structural integrity and avoid data misalignment.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 72,
                column: "TopicDesc",
                value: "Unlike sequential files that must be read from start to finish, Random Access Files allow developers to jump directly to any byte in the file. This module explores the RandomAccessFile class and the 'file pointer' concept. Students learn to read and write data at specific positions, which is essential for building database-like systems or applications that handle massive files where reading everything into memory is impossible. This topic teaches students how to optimize disk I/O for speed and efficiency, enabling near-instantaneous data retrieval from large persistent storage.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 73,
                column: "TopicDesc",
                value: "Object Serialization allows a developer to save an entire object—and its associated data—to a file as a single stream of bytes. Students learn to implement the Serializable interface and use ObjectOutputStream to 'flatten' complex object graphs. We also cover 'deserialization' to restore the objects later. This is a vital skill for saving game states, sending objects over a network, or creating persistent caches. We discuss the security implications of serialization and the use of the 'transient' keyword to exclude sensitive data from being saved to disk.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 74,
                column: "TopicDesc",
                value: "Searching through large datasets requires more than just simple loops. This module introduces the Binary Search algorithm, which finds an item in an ordered list by repeatedly halving the search space. Students learn to implement this algorithm both iteratively and recursively, analyzing its O(log n) efficiency. We emphasize that binary search requires sorted data to function. By mastering this algorithm, students gain an appreciation for computational complexity and learn how to write high-performance search logic that remains fast even as the volume of data grows exponentially.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 75,
                column: "TopicDesc",
                value: "Recursion is a programming technique where a method calls itself to solve smaller versions of a problem. This module explores the 'divide and conquer' philosophy, using recursion to solve mathematical problems like factorials and structural problems like tree traversal. Students learn to identify base cases to prevent infinite recursion and understand how the 'call stack' manages multiple active method calls. While challenging to master, recursion allows for elegant and concise solutions to complex problems that would be cumbersome to solve with traditional loops alone.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 76,
                column: "TopicDesc",
                value: "Graphical User Interfaces (GUIs) take software from the command line to a visual desktop environment. This section introduces students to libraries like Java Swing or JavaFX. Students learn to use containers, buttons, labels, and text fields to build interactive windows. We focus on 'Layout Managers'—the automated systems that handle how components are sized and positioned. This module bridges the gap between abstract logic and user interaction, teaching students how to present their programs in a professional, user-friendly format that meets modern design expectations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 77,
                column: "TopicDesc",
                value: "In a GUI environment, the program must wait for the user to act. This module explores 'Event-Driven Programming' through Action Listeners. Students learn to write code that 'listens' for mouse clicks or key presses and triggers specific methods in response. We cover the observer pattern and the use of inner classes or lambda expressions to handle these events. Mastering listeners allows students to create truly interactive software where the user is in control, enabling complex workflows like form submission, navigation, and real-time data updates within a visual interface.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 78,
                column: "TopicDesc",
                value: "This introductory module establishes the core Python syntax essential for data manipulation. Students will learn about dynamic typing, built-in data structures like lists and dictionaries, and the 'Pythonic' way of writing clean, readable code. We focus on the semantics of the language, ensuring students understand how Python manages memory and processes instructions. By mastering these fundamentals, learners build the necessary foundation to write scripts that can ingest raw data, perform transformations, and prepare datasets for the more rigorous analytical processes required in the data science paradigm.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 79,
                column: "TopicDesc",
                value: "Debugging is a critical skill in data science, where 'silent' logical errors can lead to incorrect conclusions. This module teaches students how to interpret Python tracebacks, resolve compilation warnings, and handle common runtime errors. We explore the use of integrated debuggers and print-statement strategies to track data flow through complex functions. Students will learn to distinguish between syntax errors and logical flaws in their data processing pipelines, ensuring that their code not only runs to completion but also produces mathematically accurate and reliable results from their datasets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 80,
                column: "TopicDesc",
                value: "The power of Python for data science lies in its robust ecosystem of specialized packages. This section introduces students to the core stack, including NumPy for numerical operations, Pandas for data manipulation, and Matplotlib for visualization. We discuss package management using tools like pip and Conda, and how to import libraries efficiently. Students will learn to identify which library is best suited for specific tasks—such as using Scikit-Learn for modeling or SciPy for advanced statistics—building a toolkit that allows them to leverage existing high-performance code for complex data tasks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 81,
                column: "TopicDesc",
                value: "This topic explores the overarching data science process, from data collection and cleaning to exploratory data analysis (EDA) and interpretation. Students learn the theoretical underpinnings of the field, including the importance of data ethics and the distinction between structured and unstructured data. We examine how the scientific method is applied to digital information, emphasizing the need for reproducible research and rigorous validation. By understanding these foundations, students move beyond simple coding to thinking like data scientists who can extract meaningful, evidence-based narratives from vast amounts of information.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 82,
                column: "TopicDesc",
                value: "Data science is a practical discipline used to solve tangible problems across industries like healthcare, finance, and urban planning. In this module, students analyze case studies where data-driven insights led to significant real-world improvements. We discuss how to translate a vague business problem into a concrete data science question that can be answered through programming. Students will explore applications such as predictive maintenance, sentiment analysis, and recommendation engines, gaining an appreciation for how their technical skills can be used to drive decision-making and innovation in a variety of professional contexts.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 83,
                column: "TopicDesc",
                value: "Python supports multiple programming paradigms, including functional and object-oriented approaches, each offering unique advantages for data science. This section teaches students how to choose the right paradigm for the task at hand—using functional programming for efficient data transformations or object-oriented structures for building complex, reusable simulation models. We explore how these paradigms align with modern data science workflows, allowing for scalable code that can handle increasing data volumes. Students will learn to write flexible programs that are easy to maintain and integrate into larger production-level data systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 84,
                column: "TopicDesc",
                value: "An Abstract Data Type defines a model of data and a set of operations to be performed on that data, without specifying the underlying implementation. This module teaches students to separate the 'what' from the 'how,' focusing on interface design and formal specifications. By understanding ADTs, students learn to create flexible software where the internal data structure—whether an array or a linked list—can be swapped out to optimize performance without changing the code that utilizes the data. This conceptual level of thinking is essential for managing complexity in large-scale software engineering projects.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 85,
                column: "TopicDesc",
                value: "Building on introductory concepts, this module dives into advanced recursive problem-solving and its role in data structure manipulation. Students explore the mechanics of the call stack and learn to recognize problems that possess a recursive structure, such as fractal generation and nested data. We emphasize the necessity of base cases and the risks of stack overflow. Students will practice converting iterative logic into recursive functions and vice versa, gaining a deeper understanding of how to use this powerful mathematical tool to simplify code for complex tasks like tree navigation and exhaustive search.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 86,
                column: "TopicDesc",
                value: "Asymptotic analysis provides the mathematical framework for evaluating algorithm efficiency as input sizes grow toward infinity. This topic focuses on characterizing the scaling behavior of code rather than measuring execution time in seconds. Students learn to analyze algorithms to determine their resource requirements in terms of both time and memory. We cover the methodology for identifying the dominant terms in a function and ignoring lower-order constants. This analytical skill allows developers to predict whether an algorithm will remain viable as a system scales from a few hundred items to billions of data points.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 87,
                column: "TopicDesc",
                value: "Big O Notation is the industry-standard language for expressing the upper bound of an algorithm's running time. This module covers common complexity classes, including constant, logarithmic, linear, quadratic, and exponential time. Students learn to provide 'worst-case' and 'average-case' guarantees for their code. We discuss how to identify the Big O of loops, nested structures, and recursive calls. Mastery of Big O allows students to make informed decisions when choosing between different data structures, ensuring they select the most efficient tool for the specific constraints of their hardware and application environment.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 88,
                column: "TopicDesc",
                value: "The List ADT is one of the most versatile tools in a programmer's toolkit. This section explores the conceptual requirements of a list—ordered data with index-based access—and the different ways it can be implemented. We compare the performance trade-offs of array-based lists versus dynamic structures. Students will learn the cost of common operations like insertion, deletion, and searching within different list implementations. By understanding these trade-offs, students learn to choose the correct list type based on whether their application requires frequent data access or frequent data modifications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 89,
                column: "TopicDesc",
                value: "A Stack is a 'Last-In, First-Out' (LIFO) data structure that is fundamental to many computing processes. This module explores the push, pop, and peek operations and their O(1) efficiency. We discuss real-world applications, such as undo mechanisms in text editors, expression evaluation, and managing the function call stack in memory. Students will implement stacks using both arrays and linked nodes, learning how to handle overflow and underflow conditions. This topic illustrates how restricting data access to a single end can lead to highly efficient and simplified algorithmic solutions for specific types of problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 90,
                column: "TopicDesc",
                value: "Queues follow a 'First-In, First-Out' (FIFO) principle, serving as a critical structure for managing tasks in the order they arrive. This section covers the enqueue and dequeue operations and their roles in buffer management, printer spooling, and breadth-first searches. Students will explore specialized versions like the circular queue and the priority queue. We emphasize the efficiency of these operations and the challenges of implementing them within a fixed-size array. Understanding queues is essential for building systems that handle asynchronous data streams and multi-threaded processing where task order must be strictly maintained.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 91,
                column: "TopicDesc",
                value: "Linked Lists provide a dynamic alternative to arrays, using nodes and pointers to store data in non-contiguous memory. This module covers singly, doubly, and circular linked lists. Students learn the intricacies of pointer manipulation, including the delicate process of inserting and removing nodes without breaking the chain. We analyze why linked lists offer O(1) insertions at the head but O(n) access for middle elements. This topic is a gateway to understanding complex memory management and provides the foundational architecture used in many other advanced data structures like trees and graphs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 92,
                column: "TopicDesc",
                value: "Trees are hierarchical data structures that represent parent-child relationships, moving beyond the linear limitations of lists and stacks. This section introduces tree terminology, including roots, leaves, height, and depth. Students learn the properties of general trees and the specialized constraints of binary trees, where each node has at most two children. We explore how trees are used to represent file systems, organizational charts, and XML data. Understanding tree structures allows students to organize data in ways that reflect real-world hierarchies while enabling much faster searching and sorting capabilities than linear structures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 93,
                column: "TopicDesc",
                value: "Tree traversal is the process of visiting every node in a tree exactly once. This module covers the standard depth-first search (DFS) algorithms—In-order, Pre-order, and Post-order—as well as breadth-first search (BFS). Students will implement these traversals using both recursion and iterative methods with stacks or queues. We discuss the specific use cases for each, such as using post-order for deleting trees or in-order for retrieving sorted data from a binary search tree. Mastering traversal techniques is fundamental for any operation involving non-linear data structures, from searching to data rendering.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 94,
                column: "TopicDesc",
                value: "A Binary Search Tree (BST) is a sorted tree structure that allows for highly efficient data retrieval. This module focuses on the BST property: for every node, the left subtree contains smaller values and the right subtree contains larger ones. Students will implement insertion, deletion, and search algorithms, analyzing their average-case O(log n) efficiency. We also discuss the 'worst-case' scenario of a skewed tree, which can degrade to O(n) performance. Understanding BSTs teaches students how maintaining internal order during data insertion can significantly accelerate future search operations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 95,
                column: "TopicDesc",
                value: "The Dictionary ADT maps unique keys to specific values, and a BST is an excellent candidate for its implementation. This module explores how to use a Binary Search Tree to manage key-value pairs, providing a structure for fast lookups, insertions, and deletions. Students learn to handle duplicate keys and how to utilize the BST property to efficiently find the predecessor or successor of a given element. This application illustrates the practical utility of trees in building real-world software components like symbol tables in compilers or contact lists in mobile applications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 96,
                column: "TopicDesc",
                value: "Insertion Sort is a classic algorithm that builds a sorted array one item at a time, similar to how a person might sort a hand of playing cards. This module covers the implementation of the algorithm and its O(n²) complexity. We discuss why it remains highly efficient for small datasets or nearly-sorted data despite its poor worst-case performance. Students will analyze the algorithm's stability and in-place nature. This topic serves as a benchmark for comparing more complex sorting methods and introduces the fundamental logic of 'swapping' and 'shifting' that underpins many data manipulation techniques.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 97,
                column: "TopicDesc",
                value: "The Java Collection Framework (JCF) provides a set of high-performance, ready-to-use implementations of the data structures studied in this course. This module covers the Hierarchy of the JCF, including the List, Set, and Map interfaces. Students learn to use standard classes like ArrayList, LinkedList, and HashMap in their projects. We emphasize the importance of choosing the right collection based on the performance characteristics learned earlier. By the end of this section, students will be proficient in using industry-standard libraries to implement complex data logic quickly and reliably.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 98,
                column: "TopicDesc",
                value: "As data structures become more complex, manual testing becomes impossible. This module introduces Unit Testing as a critical component of the development lifecycle. Students learn to use frameworks like JUnit to write automated tests that verify the correctness of their data structure implementations. We focus on 'edge cases,' such as adding to a full structure or removing from an empty one. By adopting a test-driven mindset, students ensure their structures are robust and reliable, significantly reducing the time spent debugging in the later stages of software production.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 99,
                column: "TopicDesc",
                value: "Backtracking is an algorithmic technique for solving problems recursively by trying to build a solution incrementally and removing solutions that fail to satisfy constraints. This module explores the 'state-space search' and how to prune search trees to improve efficiency. We use motivating problems like the N-Queens puzzle, maze solving, or the Knapsack problem to demonstrate the technique. Students learn how to manage the program state and use the call stack to 'undo' choices. This final topic combines recursion, tree logic, and efficiency analysis into a sophisticated problem-solving strategy.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 100,
                column: "TopicDesc",
                value: "This introductory module bridges the gap between linear data structures and hierarchical ones. We examine the fundamental properties of trees, including root nodes, leaf nodes, and subtrees. Students will explore how tree-based organization allows for more efficient searching and data management compared to arrays or linked lists, setting the stage for more specialized tree implementations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 101,
                column: "TopicDesc",
                value: "Focusing on the most common tree structure, this topic covers the properties of binary trees where each node has at most two children. We analyze traversal methods—In-order, Pre-order, and Post-order—and discuss the mathematical relationship between the height of the tree and the number of nodes, which is critical for future complexity analysis.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 102,
                column: "TopicDesc",
                value: "Binary Search Trees (BST) provide a framework for efficient data retrieval. This section focuses on the 'ordering property' that allows for O(log n) average-case search time. Students will implement insertion and deletion algorithms and analyze how the 'shape' of the tree directly impacts the performance of search operations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 103,
                column: "TopicDesc",
                value: "To address the performance degradation of skewed trees, we study self-balancing mechanisms. This module introduces the concept of 'rotations' to maintain a logarithmic height. By ensuring the tree remains balanced, we guarantee worst-case performance bounds for dynamic data sets that undergo frequent updates.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 104,
                column: "TopicDesc",
                value: "Moving beyond binary structures, 2-3 trees introduce multi-way search trees. This topic explores how nodes containing multiple keys and children can stay perfectly balanced. Students will learn the 'split and promote' logic used during insertion, providing a conceptual foundation for more complex external memory structures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 105,
                column: "TopicDesc",
                value: "Designed for systems handling massive amounts of data, B-trees are the standard for file systems and databases. This module covers how B-trees minimize disk I/O by utilizing block-sized nodes. We analyze the branching factor and how these structures maintain efficiency even when the data set is too large to fit into primary memory.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 106,
                column: "TopicDesc",
                value: "We explore the Min-Heap and Max-Heap, which are specialized complete binary trees that satisfy the heap property. This section covers the 'heapify' process and how arrays can be used for efficient concrete implementation without the overhead of pointers, emphasizing the relationship between logical structure and memory layout.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 107,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Priority Queues", "Building on heap logic, this topic introduces the Priority Queue ADT. We discuss its application in operating system scheduling and simulation. Students will compare the efficiency of implementing priority queues using sorted lists versus heaps, reinforcing the course's focus on choosing the right tool for the job." });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 108,
                column: "TopicDesc",
                value: "Hashing provides a method for O(1) average-case data access. This module covers hash functions, collision resolution strategies like chaining and open addressing (linear probing, quadratic probing), and the concept of 'load factor.' We analyze how the choice of a hash function affects the distribution of data and overall performance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 109,
                column: "TopicDesc",
                value: "This topic explores the Map (or Dictionary) interface, which stores data in key-value pairs. We discuss the conceptual mapping of unique keys to specific values and how different underlying structures—such as Hash Tables or Red-Black Trees—change the performance characteristics of the 'put' and 'get' operations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 110,
                column: "TopicDesc",
                value: "Students will learn about the Set ADT, which models a collection of unique elements. We cover mathematical set operations like union, intersection, and difference. Implementation strategies are discussed, focusing on how hashing or tree-based logic can be leveraged to efficiently enforce the uniqueness constraint.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 111,
                column: "TopicDesc",
                value: "This module examines the representation and manipulation of two-dimensional data. We focus on the trade-offs between dense and sparse matrices, exploring memory-efficient ways to store data sets where most elements are zero. This is a key topic for students interested in scientific computing and image processing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 112,
                column: "TopicDesc",
                value: "As one of the most versatile data structures, graphs represent complex relationships between objects. We cover Adjacency Lists and Adjacency Matrices, along with fundamental traversal algorithms like Breadth-First Search (BFS) and Depth-First Search (DFS). Students will learn to model real-world problems like networking and pathfinding.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 113,
                column: "TopicDesc",
                value: "A core pillar of CS 302, this topic teaches students how to mathematically prove the efficiency of an algorithm. We move from intuitive timing to Big-O, Big-Omega, and Big-Theta notation. Students will practice counting primitive operations and solving recurrence relations to characterize worst and average-case requirements.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 114,
                column: "TopicDesc",
                value: "Revisiting the tree structure with a focus on advanced applications. This module explores non-linear data organization in the context of file systems and hierarchical data formats like XML or JSON. We emphasize the transition from conceptual tree diagrams to concrete memory management in high-level programming languages.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 115,
                column: "TopicDesc",
                value: "This section reinforces the separation of 'what' a data structure does from 'how' it is implemented. By defining ADTs, students learn to create modular, reusable code. We focus on the formal specification of data structures and how this abstraction allows developers to swap implementations without changing the client-side code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 116,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Demonstrate the Association between Abstract Data Types and Basic Java Constructs", "The final module connects theory to practice by mapping ADTs to the Java Collections Framework. Students will use Interfaces, Generics, and Classes to implement the structures studied in class. This provides hands-on experience in using real programming environments to solve complex data manipulation problems." });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 117,
                column: "TopicDesc",
                value: "The foundation of computer arithmetic starts with understanding how data is represented at the hardware level. This module covers conversions between Binary, Decimal, and Hexadecimal systems. Students will learn to perform manual conversions, understand two's complement for signed integers, and recognize why hexadecimal is the standard 'shorthand' for viewing memory addresses and machine code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 118,
                column: "TopicDesc",
                value: "This topic explores the physical and logical organization of memory. We examine the hierarchy from fast CPU caches to main RAM. Students will learn how the CPU fetches instructions and data, the concept of byte-addressability, and 'Endianness' (Little-endian vs. Big-endian), which dictates how multi-byte data types are stored in memory cells.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 119,
                column: "TopicDesc",
                value: "In 64-bit mode, the addressable memory space is vast. This module focuses on how the operating system and hardware map virtual addresses to physical memory. We discuss the flat memory model used in x86-64, the layout of a program's address space (Stack, Heap, Data, and Text segments), and how the 'ebe' interface helps visualize these memory regions during execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 120,
                column: "TopicDesc",
                value: "Registers are the fastest storage locations inside the CPU. We study the evolution from 32-bit (EAX, EBX, etc.) to 64-bit (RAX, RBX, and R8-R15) registers. This section covers register naming conventions, the use of sub-registers for smaller data types, and the specific roles of the Instruction Pointer (RIP) and Stack Pointer (RSP) in controlling program flow.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 121,
                column: "TopicDesc",
                value: "Students will implement mathematical operations using Assembly instructions like ADD, SUB, MUL, and DIV. This topic emphasizes how arithmetic affects the CPU 'Flags' register (Zero, Sign, and Overflow flags). We explore the difference between signed and unsigned arithmetic and how the hardware handles carries and overflows during high-speed calculations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 122,
                column: "TopicDesc",
                value: "This module covers low-level manipulation of individual bits using logical operators: AND, OR, XOR, and NOT, as well as SHIFT and ROTATE instructions. Students will learn how to use 'bitmasking' to isolate specific data within a register, a crucial skill for device driver development and optimizing performance-critical code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 123,
                column: "TopicDesc",
                value: "Moving away from linear execution, this topic introduces control flow. We cover 'Jump' instructions (JZ, JNZ, JGE, etc.) and how they interact with the Flags register to create IF-THEN-ELSE structures and WHILE/FOR loops. Students will learn to translate high-level logic into the conditional and unconditional jumps that the CPU understands.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 124,
                column: "TopicDesc",
                value: "The final module addresses modular programming via the CALL and RET instructions. We focus on the 'Calling Convention' for x86-64, including how parameters are passed via registers (RDI, RSI, RDX, etc.) and how the Stack is used to preserve local variables and return addresses. This topic bridges the gap between writing simple scripts and building complex, structured programs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 125,
                column: "TopicDesc",
                value: "This introductory module distinguishes between computer architecture (the attributes visible to a programmer) and computer organization (the operational units). We examine the 'Von Neumann' architecture and the historical milestones that led from vacuum tubes to VLSI circuits, providing context for modern system design.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 126,
                column: "TopicDesc",
                value: "Using Boolean algebra as a foundation, students will design and analyze combinational and sequential circuits. We use tools like MultiMedia Logic to build fundamental components such as adders, multiplexers, and flip-flops, demonstrating how simple logic gates are combined to create complex functional units.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 127,
                column: "TopicDesc",
                value: "This section focuses on the metrics used to evaluate computer performance, such as clock speed, CPI (Cycles Per Instruction), and MIPS. We analyze 'Amdahl’s Law' and discuss how architectural improvements must balance power consumption, heat dissipation, and execution speed.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 128,
                column: "TopicDesc",
                value: "We explore the pathways that allow the CPU, memory, and I/O modules to communicate. This module covers bus structures, arbitration schemes, and point-to-point interconnects. Students will learn how timing and data width affect the overall throughput and scalability of a computer system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 129,
                column: "TopicDesc",
                value: "Focusing on the 'Principle of Locality,' we study how cache memory bridges the performance gap between the CPU and RAM. Topics include mapping functions (direct, associative, and set-associative), replacement algorithms like LRU, and write policies used to maintain data consistency.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 130,
                column: "TopicDesc",
                value: "This module examines the technology behind semiconductor main memory. We compare DRAM and SRAM, explore error correction codes (ECC) such as Hamming codes, and discuss the internal organization of memory chips and modules to understand how data is stored and refreshed.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 131,
                column: "TopicDesc",
                value: "We analyze the various techniques used by the CPU to communicate with external devices. This includes Programmed I/O, Interrupt-Driven I/O, and Direct Memory Access (DMA). Students will learn how I/O channels and processors offload tasks from the CPU to improve system efficiency.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 132,
                column: "TopicDesc",
                value: "This first look at Instruction Set Architecture (ISA) focuses on machine instruction characteristics, operand types, and data formats. We examine how different processors represent operations and the trade-offs involved in designing a set of instructions that is both powerful and efficient to implement.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 133,
                column: "TopicDesc",
                value: "Continuing our study of ISAs, we dive into addressing modes and instruction formats. Students will compare how different architectures—such as x86 and ARM—handle memory references and how these choices impact the complexity of the compiler and the hardware decoder.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 134,
                column: "TopicDesc",
                value: "This module explores the internal workings of the CPU, including the Control Unit, the Arithmetic Logic Unit (ALU), and the register file. We analyze the fetch-decode-execute cycle and how the control unit manages the flow of data through the data path to execute instructions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 135,
                column: "TopicDesc",
                value: "We compare the RISC philosophy with Complex Instruction Set Computers (CISC). This topic highlights the advantages of simple, fixed-length instructions, the use of large register sets, and how RISC architectures facilitate more efficient pipelining and hardware implementation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 136,
                column: "TopicDesc",
                value: "To increase performance, modern processors execute multiple instructions simultaneously. We study pipelining hazards, branch prediction, and superscalar execution. Students will learn how hardware can dynamically reorder instructions to keep functional units busy while maintaining logical correctness.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 137,
                column: "TopicDesc",
                value: "The course concludes with an introduction to massively parallel architectures. We explore how GPUs, originally designed for graphics, are used for general-purpose scientific computing. This includes an overview of the SIMT (Single Instruction, Multiple Threads) model and the architectural differences between CPUs and GPUs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 138,
                column: "TopicDesc",
                value: "This module establishes the professional standards for CS communication. Students explore the ethics of data representation, intellectual property, and the importance of clarity and conciseness. We focus on the iterative process of drafting and peer-editing to transform raw technical notes into polished, professional documentation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 139,
                column: "TopicDesc",
                value: "Students learn to distill complex technical papers or project specifications into high-level executive summaries. This involves identifying core contributions, removing jargon for non-technical stakeholders, and ensuring that the most critical information is accessible at a glance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 140,
                column: "TopicDesc",
                value: "Data is only as useful as its presentation. This section covers the principles of visual rhetoric—choosing the right chart type to represent specific data sets, ensuring accessibility, and integrating visualizations into text to support technical arguments effectively.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 141,
                column: "TopicDesc",
                value: "Focusing on career development, students craft persuasive cover letters for industry positions. We analyze how to map specific technical skills (like those gained in CS 302 or 311) to job descriptions, demonstrating value to recruiters through professional tone and structured narrative.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 142,
                column: "TopicDesc",
                value: "Modeling the academic and professional peer-review process, students learn to provide constructive, critical feedback on technical work. This module emphasizes objectivity, identifying logical fallacies, and suggesting concrete improvements in a professional, non-confrontational manner.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 143,
                column: "TopicDesc",
                value: "Technical instructions must be foolproof. Students learn to write step-by-step procedures, such as software installation guides or API documentation. We focus on imperative mood, logical sequencing, and the use of warnings/cautions to ensure user success and safety.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 144,
                column: "TopicDesc",
                value: "This major project involves identifying a research gap and proposing a technical solution. Students use APA documentation to cite sources and write annotations that evaluate the relevance and authority of existing literature, setting the stage for formal research.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 145,
                column: "TopicDesc",
                value: "A deep dive into existing research, this topic teaches students how to synthesize multiple sources into a cohesive narrative. Rather than summarizing individual papers, students learn to identify 'themes' across the field and describe the current state of the art in a specific CS domain.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 146,
                column: "TopicDesc",
                value: "Technical speaking requires different slide design than general presentations. We cover the 'Assertion-Evidence' structure, focusing on minimizing text, using high-quality diagrams, and maintaining professional delivery during oral presentations of technical data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 147,
                column: "TopicDesc",
                value: "This assessment ensures mastery of the technicalities of writing. We review grammar, punctuation, and specific APA formatting rules (citations, references, and headings) to ensure all student output meets the rigorous mechanical standards of the CS industry.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 148,
                column: "TopicDesc",
                value: "We review the client-server model and the HTTP request/response cycle. This module sets the stage for advanced development by ensuring students understand how browsers interact with web servers and how data flows across the internet.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 149,
                column: "TopicDesc",
                value: "Before moving to the server, we reinforce modern front-end standards. Students will master semantic HTML for accessibility and advanced CSS techniques (like Flexbox or Grid) for creating responsive layouts that adapt to various screen sizes.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 150,
                column: "TopicDesc",
                value: "This topic covers client-side logic to add interactivity to the web. We examine DOM manipulation, event handling, and basic asynchronous programming, allowing students to create dynamic user experiences without requiring a page reload.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 151,
                column: "TopicDesc",
                value: "Students explore the jQuery library to simplify JavaScript tasks. We focus on selecting elements, handling events, and performing AJAX calls to fetch data from the server, emphasizing write-less-do-more patterns for rapid web prototyping.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 152,
                column: "TopicDesc",
                value: "The core of the course: server-side scripting. Students learn PHP syntax, variables, and control structures. We focus on how PHP generates dynamic HTML on the fly and manages session data to keep users logged in across different pages.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 153,
                column: "TopicDesc",
                value: "Integrating all previous skills, students design a full-stack application. This involves database schema design using SQL, connecting the PHP backend to the database, and implementing CRUD (Create, Read, Update, Delete) functionality for a complete user system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 154,
                column: "TopicDesc",
                value: "Web development does not exist in a vacuum. This module explores ethical considerations such as data privacy (GDPR), web security (preventing SQL injection), and the social impact of algorithmic bias in modern web applications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 155,
                column: "TopicDesc",
                value: "The core building blocks of C programming are examined through the lens of machine representation. This module covers primitive data types, their bit-widths, and the precedence of arithmetic and logical operators. Analysis of expressions ensures a deep understanding of how the compiler evaluates complex operations and handles type promotion.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 156,
                column: "TopicDesc",
                value: "Control flow is established through conditional execution and iteration. This section focuses on the logical evaluation of relational and logical operators within if-else structures and switch statements. Students master the mechanics of loop constructs (for, while, do-while) to manage repetitive tasks and program state transitions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 157,
                column: "TopicDesc",
                value: "Modular programming is achieved by defining functions and understanding the lifecycle of variables. This topic explores the difference between local and global scope, as well as the 'extent' or duration of variables in memory (static vs. automatic). Mastery of the call stack and parameter passing is essential for building scalable applications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 158,
                column: "TopicDesc",
                value: "Direct memory access is the hallmark of the C language. This module covers pointer arithmetic, the relationship between arrays and memory addresses, and the representation of null-terminated strings. Students learn to navigate and manipulate memory layouts, providing the foundation for high-performance software development.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 159,
                column: "TopicDesc",
                value: "Manual memory management is explored through the use of malloc, calloc, and free. This section emphasizes the importance of the heap, the prevention of memory leaks, and the risks of dangling pointers. Students gain hands-on experience in allocating and resizing memory at runtime to handle variable-sized data sets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 160,
                column: "TopicDesc",
                value: "Custom data types are created to model real-world entities. This topic covers 'structs' for grouping related data and 'unions' for memory-efficient storage where multiple variables share the same memory space. Emphasis is placed on memory alignment and the use of pointers to structures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 161,
                column: "TopicDesc",
                value: "Interaction with the outside world is facilitated through standard I/O libraries. This module focuses on formatted input and output (scanf and printf) and file-level operations. Students learn to handle data streams, buffers, and error states when reading from or writing to external files and devices.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 162,
                column: "TopicDesc",
                value: "A comparative study marks the transition from procedural to object-oriented programming. Key differences such as namespaces, function overloading, and the 'reference' type are analyzed. This module highlights how C++ maintains backward compatibility with C while introducing safer and more expressive language constructs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 163,
                column: "TopicDesc",
                value: "The fundamentals of Object-Oriented Programming (OOP) are introduced through C++ classes. This section covers encapsulation, constructors, and access specifiers (public, private, protected). Students learn to design objects that bundle data and behavior, facilitating better abstraction and code reuse.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 164,
                column: "TopicDesc",
                value: "Functional programming is introduced using the ML language family. This module covers the core philosophy of 'immutability' and functions as first-class citizens. Students practice writing recursive functions and using pattern matching to process complex data types without the side effects common in imperative languages.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 165,
                column: "TopicDesc",
                value: "Advanced type systems are analyzed, including static vs. dynamic typing and strong vs. weak typing. The module explores how type inference algorithms (like Hindley-Milner) allow languages to ensure type safety without requiring explicit annotations, improving both reliability and developer productivity.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 166,
                column: "TopicDesc",
                value: "The ability of code to operate on different types is a cornerstone of modern language design. This topic examines parametric polymorphism (generics), ad-hoc polymorphism (overloading), and subtyping. Students learn how these mechanisms allow for more flexible and reusable software components.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 167,
                column: "TopicDesc",
                value: "Theoretical models of naming and binding are investigated. This module contrasts static (lexical) scope with dynamic scope, analyzing how each impacts the visibility of variables and the behavior of closures. Understanding the environment and symbol tables is critical for grasping how compilers and interpreters function.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 168,
                column: "TopicDesc",
                value: "As hardware moves toward multi-core architectures, software must follow. This section focuses on decomposing problems into tasks that can execute simultaneously. Students study data parallelism vs. task parallelism and learn to identify dependencies that limit the speedup of parallel systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 169,
                column: "TopicDesc",
                value: "The practical implementation of parallelism is explored through threads and synchronization. This module covers the challenges of race conditions, deadlocks, and atomicity. Students analyze various primitives like semaphores, monitors, and message passing used to coordinate concurrent activities safely.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 170,
                column: "TopicDesc",
                value: "The Sieve of Eratosthenes is utilized as a case study for algorithmic efficiency and parallelization. Students implement this ancient prime-finding method to demonstrate how a simple iterative process can be transformed into a high-performance parallel application across multiple processing units.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 171,
                column: "TopicDesc",
                value: "Graph theory and dynamic programming converge in Floyd-Warshall’s all-pairs shortest path algorithm. This topic focuses on the algorithm's recursive structure and its suitability for parallel processing. Analysis of its O(n^3) complexity provides a concrete example of when and how to apply parallel optimization techniques.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 172,
                column: "TopicDesc",
                value: "Instruction focuses on how software engineering principles dictate the efficient use of system resources. This module explores how different variables and data structures occupy space in memory, emphasizing the importance of lifecycle management to ensure system stability and performance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 173,
                column: "TopicDesc",
                value: "This section examines the classification of data from a system analysis perspective. Students learn how to select types that accurately reflect real-world requirements while optimizing storage and ensuring data integrity throughout the application's execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 174,
                column: "TopicDesc",
                value: "Foundational computation logic is established through standard mathematical operators. Beyond simple calculation, this topic addresses the engineering concern of numerical precision and the potential for overflow errors in financial or scientific software modules.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 175,
                column: "TopicDesc",
                value: "The linear execution of code is explored as the first step in the implementation phase of the SDLC. This module highlights the importance of logical flow and clear documentation to ensure that the sequential steps of an algorithm are maintainable by other engineers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 176,
                column: "TopicDesc",
                value: "A critical aspect of software quality assurance, this topic focuses on defensive programming. Students learn to implement validation logic that cleanses and verifies user input, protecting the system from malformed data and security vulnerabilities at the entry point.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 177,
                column: "TopicDesc",
                value: "Decision-making structures are built using comparison logic. This module teaches how to translate complex business rules and system requirements into precise relational expressions that guide the software’s behavior during runtime.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 178,
                column: "TopicDesc",
                value: "Advanced logic is mastered by combining multiple conditions into cohesive Boolean statements. Students apply these expressions to manage complex branching paths, ensuring that all logical edge cases defined during the system analysis phase are addressed.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 179,
                column: "TopicDesc",
                value: "Iterative processes are analyzed to ensure they meet performance and reliability standards. This section covers the design of exit criteria for loops, preventing infinite cycles and ensuring that repetitive tasks complete accurately within the program's architectural constraints.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 180,
                column: "TopicDesc",
                value: "Promoting the principles of abstraction and encapsulation, this module focuses on breaking down monolithic code into manageable procedures. Students learn to create reusable interfaces that simplify the complexity of the overall software architecture.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 181,
                column: "TopicDesc",
                value: "This topic addresses the requirement for data persistence within the SDLC. Instruction covers the systematic reading and writing of data to external files, allowing for the long-term storage of state and the creation of audit logs and permanent records.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 182,
                column: "TopicDesc",
                value: "Students explore structured data management using multi-dimensional arrays. This section emphasizes the engineering trade-offs of using fixed-size collections for data storage and the algorithmic patterns required to traverse and manipulate complex data grids.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 183,
                column: "TopicDesc",
                value: "The culmination of the course focuses on Object-Oriented Analysis and Design (OOAD). Using UML concepts, students learn to model systems as collections of interacting objects, mastering encapsulation, inheritance, and polymorphism to create robust, maintainable solutions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 184,
                column: "TopicDesc",
                value: "The module covers the foundational step of establishing a Linux environment. Students explore various distributions, disk partitioning strategies, and the installation of core system components, setting the stage for hands-on administration and configuration.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 185,
                column: "TopicDesc",
                value: "The terminal is the primary interface for Linux administration. This topic introduces the 'Shell' and focuses on navigating the filesystem, manipulating files, and executing core utilities that form the backbone of the Linux user experience.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 186,
                column: "TopicDesc",
                value: "Deepening command-line proficiency, this section examines how the shell processes text before execution. Students learn to use wildcards, variables, and brace expansions to perform powerful, bulk operations with minimal manual typing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 187,
                column: "TopicDesc",
                value: "Following the Linux philosophy of 'doing one thing well,' this module teaches students how to chain individual tools together. Using pipes (|) and redirects, learners build complex data-processing pipelines from simple, standard commands.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 188,
                column: "TopicDesc",
                value: "Automation is a core skill for Linux administrators. This topic introduces Bash scripting, covering variables, loops, and conditional logic. Students learn to write scripts that automate repetitive system tasks, improving efficiency and reducing human error.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 189,
                column: "TopicDesc",
                value: "This section focuses on the administrative responsibility of managing system access. Students learn to create, modify, and delete user accounts and groups, ensuring that the system remains organized and that users have appropriate levels of access.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 190,
                column: "TopicDesc",
                value: "Security is addressed through the Linux permission model. Instruction covers the Read/Write/Execute bits, ownership properties, and the use of 'chmod' and 'chown' to protect sensitive data and maintain the integrity of the operating system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 191,
                column: "TopicDesc",
                value: "Different methodologies for managing software production are analyzed, including Waterfall, Agile, and Scrum. This module explores how choosing a lifecycle impacts project flexibility, risk management, and delivery timelines, ensuring students can select the right process for a given team and set of constraints.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 192,
                column: "TopicDesc",
                value: "Effective engineering requires foresight. This topic covers the estimation of resources, time, and budget. Students learn to use planning tools to create milestones and track progress, balancing the technical debt with the need for timely feature delivery.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 193,
                column: "TopicDesc",
                value: "Defining boundaries is critical to project success. This module focuses on establishing what a project will and will not include, helping engineers prevent 'scope creep' and manage stakeholder expectations through formal documentation and agreement.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 194,
                column: "TopicDesc",
                value: "The elicitation of functional and non-functional requirements serves as the project's foundation. Students learn to translate vague user needs into precise technical specifications that guide the design and testing phases of the software lifecycle.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 195,
                column: "TopicDesc",
                value: "User-centric design is explored through Use Case modeling. This section teaches students how to identify actors and their goals, documenting the interactions between users and the system to ensure that the final product addresses real-world scenarios.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 196,
                column: "TopicDesc",
                value: "Dynamic system behavior is visualized through Sequence Diagrams. This topic covers the chronological interaction between objects, detailing how messages are passed and how control flow moves through the system during a specific use case execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 197,
                column: "TopicDesc",
                value: "Proven solutions to recurring software design problems are examined. Students explore standard Java patterns, such as Singleton, Factory, and Observer, learning how to apply these templates to create code that is more modular, flexible, and easy to maintain.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 198,
                column: "TopicDesc",
                value: "The workflow of a system is modeled using Activity Diagrams. This module focuses on representing the logic of a process, including decision points, parallel activities, and synchronization, providing a clear map of the system's operational flow.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 199,
                column: "TopicDesc",
                value: "Static system structure is defined through Class Diagrams. Students learn to model classes, attributes, methods, and the complex relationships (association, aggregation, and inheritance) that form the backbone of an object-oriented application.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 200,
                column: "TopicDesc",
                value: "Quality assurance is managed through the design of rigorous test cases. This section covers black-box and white-box testing strategies, ensuring that every functional requirement is verified and that the software remains robust under both normal and edge-case conditions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 201,
                column: "TopicDesc",
                value: "The module introduces the fundamental concepts of database systems, contrasting them with traditional file-based storage. Analysis focuses on the different roles within the database environment, from end-users to Database Administrators (DBAs), and the importance of data independence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 202,
                column: "TopicDesc",
                value: "Students examine the three-schema architecture (Internal, Conceptual, and External). This topic explains how schemas provide a framework for data abstraction, allowing changes to the physical storage layer without affecting the way users perceive or access the data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 203,
                column: "TopicDesc",
                value: "The core of modern database design is explored through the relational model. Students learn about tuples, attributes, and relations, understanding how data is organized into tables that can be logically linked through shared keys.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 204,
                column: "TopicDesc",
                value: "Data integrity is enforced through formal constraints. This module covers Domain, Key, and Entity Integrity constraints, as well as Referential Integrity using foreign keys, ensuring that the database remains consistent and accurate across all operations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 205,
                column: "TopicDesc",
                value: "The mathematical relationship between attributes is analyzed. Students learn to identify functional dependencies ($X 	o Y$), which serve as the primary tool for assessing the quality of a relation and the foundation for the normalization process.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 206,
                column: "TopicDesc",
                value: "To eliminate data redundancy and update anomalies, students apply the principles of Normalization. This section covers the transformation of tables into First, Second, and Third Normal Forms (1NF, 2NF, 3NF), and occasionally Boyce-Codd Normal Form (BCNF).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 207,
                column: "TopicDesc",
                value: "High-level database design is mastered through Entity-Relationship modeling. Students learn to identify entities, attributes, and relationships, creating ER diagrams that serve as a blueprint for the physical implementation of the database.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 208,
                column: "TopicDesc",
                value: "The formal, procedural query language that underpins SQL is studied. This module covers fundamental operations such as Select, Project, Union, Set Difference, and Cartesian Product, providing the mathematical theory behind data manipulation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 209,
                column: "TopicDesc",
                value: "A non-procedural approach to data retrieval is examined through Tuple and Domain Relational Calculus. This section emphasizes the declarative nature of database queries—describing 'what' data is needed rather than 'how' to retrieve it.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 210,
                column: "TopicDesc",
                value: "The industry-standard language for database interaction is mastered. Students learn Data Definition Language (DDL) to create structures and Data Manipulation Language (DML) to query and modify data, with a focus on complex JOINs, subqueries, and aggregation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 211,
                column: "TopicDesc",
                value: "Effective software begins with a robust blueprint. This module explores the creative process of designing logic to solve computational problems, emphasizing the selection of appropriate data structures and paradigms to meet specific performance goals.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 212,
                column: "TopicDesc",
                value: "Evaluation of efficiency is performed using asymptotic notations like Big-O, Big-Theta, and Big-Omega. Analysis focuses on predicting the growth rate of an algorithm's execution time and memory consumption as the input size approaches infinity.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 213,
                column: "TopicDesc",
                value: "This topic shifts focus from specific algorithms to the inherent difficulty of the problems themselves. Analysis determines the lower bounds of performance required to solve a problem, helping engineers recognize when a solution is optimal or when a problem is fundamentally intractable.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 214,
                column: "TopicDesc",
                value: "Complex problems are solved by recursively breaking them into smaller sub-problems of the same type. This section covers classic examples like Merge Sort and Quick Sort, analyzing the master theorem to solve the resulting recurrence relations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 215,
                column: "TopicDesc",
                value: "To avoid redundant calculations, this strategy stores the results of sub-problems in a table. Students learn to identify optimal substructure and overlapping sub-problems, applying techniques like memoization and bottom-up iteration to problems like the Knapsack or Longest Common Subsequence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 216,
                column: "TopicDesc",
                value: "This approach makes the locally optimal choice at each step with the hope of finding a global optimum. Analysis focuses on proving the 'Greedy Choice Property' and examining applications such as Huffman coding and Prim's minimum spanning tree algorithm.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 217,
                column: "TopicDesc",
                value: "Systematic exploration of a state-space tree allows for finding solutions by abandoning paths that fail to meet constraints. This module utilizes problems like the N-Queens or Hamiltonian circuits to demonstrate the power of depth-first search with pruning.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 218,
                column: "TopicDesc",
                value: "Used primarily for optimization problems, this strategy explores a state-space tree but uses 'bounding' functions to prune branches that cannot yield a better solution than the current best. This section contrasts the approach with backtracking and greedy methods.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 219,
                column: "TopicDesc",
                value: "The boundary of practical computing is examined through the P vs. NP question. This topic introduces the concept of reduction, showing how a set of 'hard' problems (like 3-SAT) are related and why finding a polynomial-time solution for one would revolutionize the field.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 220,
                column: "TopicDesc",
                value: "When finding an exact solution is computationally impossible (NP-hard), approximation strategies are used. Students learn to design algorithms that find 'near-optimal' solutions within a provable factor of the true optimum for problems like the Traveling Salesperson.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 221,
                column: "TopicDesc",
                value: "The course concludes with the mathematical proof of performance limits. Analysis demonstrates why certain problems, such as comparison-based sorting, have an inescapable lower bound of O(n log n), defining the absolute peak of efficiency possible.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 222,
                column: "TopicDesc",
                value: "Theoretical graphs are translated into concrete code. This module compares the storage and performance trade-offs of Adjacency Matrices versus Adjacency Lists, focusing on how the choice of representation impacts the complexity of subsequent algorithms.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 223,
                column: "TopicDesc",
                value: "Instruction focuses on symmetric relationships where edges have no orientation. Analysis covers basic connectivity, degree of vertices, and the implementation of algorithms to find Minimum Spanning Trees (MST) using Kruskal's or Prim's methods.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 224,
                column: "TopicDesc",
                value: "One-way relationships are explored through directed edges (arcs). This section addresses the unique challenges of reachability and strongly connected components, analyzing how directed edges model dependencies in compilers and task scheduling.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 225,
                column: "TopicDesc",
                value: "Specialized directed graphs without cycles are analyzed for their role in modeling hierarchies and workflows. Students master Topological Sorting and examine how DAGs facilitate efficient shortest-path calculations in dynamic programming.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 226,
                column: "TopicDesc",
                value: "As a specific subset of graphs, trees are examined for their property of being connected and acyclic. Analysis covers rooted trees, spanning trees, and the mathematical properties that distinguish trees from more general graph structures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 227,
                column: "TopicDesc",
                value: "A formal mathematical vocabulary is established. Topics include paths, cycles, cliques, degrees, and walk types, ensuring students can precisely describe graph characteristics in academic and professional contexts.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 228,
                column: "TopicDesc",
                value: "Tracing a path that visits every edge exactly once is explored. This section covers the conditions required for a graph to possess an Eulerian cycle and the Hierholzer algorithm used to find one, a classic problem in network traversal.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 229,
                column: "TopicDesc",
                value: "Finding the most efficient route between nodes is a core graph task. This module covers Dijkstra's algorithm for non-negative weights, Bellman-Ford for negative weights, and A* search for heuristic-driven pathfinding.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 230,
                column: "TopicDesc",
                value: "Transportation networks are modeled to determine the maximum amount of 'flow' from a source to a sink. Using the Ford-Fulkerson method and the Edmonds-Karp algorithm, students solve capacity-constrained logistics problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 231,
                column: "TopicDesc",
                value: "The Max-Flow Min-Cut Theorem is analyzed to show that the maximum flow through a network is equal to the minimum capacity of a cut that separates the source from the sink, a vital concept in network reliability and image segmentation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 232,
                column: "TopicDesc",
                value: "Graphs where nodes can be divided into two independent sets are used to solve assignment problems. Analysis focuses on finding the maximum matching using flow-based algorithms, modeling scenarios like job assignments or marriage pairings.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 233,
                column: "TopicDesc",
                value: "This topic explores whether a graph can be drawn in a plane without any edges crossing. Students study Euler’s formula for planar graphs and Kuratowski's theorem, which identifies non-planar structures like $K_5$ and $K_{3,3}$.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 234,
                column: "TopicDesc",
                value: "Fundamental traversal techniques like Breadth-First Search (BFS) and Depth-First Search (DFS) are mastered. This module explains how these searches form the basis for more complex algorithms like cycle detection and connectivity testing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 235,
                column: "TopicDesc",
                value: "Identification of 'critical' edges whose removal increases the number of connected components is covered. Students learn Tarjan’s algorithm to find bridges, a key task in analyzing the vulnerability of communication networks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 236,
                column: "TopicDesc",
                value: "Similar to bridges, articulation points are vertices that, if removed, disconnect the graph. This section focuses on identifying these points to determine the 'biconnectivity' of a network and its overall structural robustness.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 237,
                column: "TopicDesc",
                value: "Methods for identifying maximal subgraphs where all nodes are reachable from one another are explored. This includes finding strongly connected components in directed graphs using Kosaraju’s or Tarjan’s algorithms.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 238,
                column: "TopicDesc",
                value: "Hierarchical organization of graphs is examined, often used in graph drawing and layered layouts. This topic explores how to divide nodes into discrete ranks or layers to visualize dependencies and flow more clearly.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 239,
                column: "TopicDesc",
                value: "The aesthetics and utility of graph visualization are analyzed. This module covers layout algorithms, such as force-directed or orthogonal layouts, focusing on how to represent complex networks in a way that is human-readable.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 240,
                column: "TopicDesc",
                value: "The challenge of determining if two graphs are structurally identical despite different visual representations is investigated. Students examine the complexity of the isomorphism problem and the invariants used to check for structural equivalence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 241,
                column: "TopicDesc",
                value: "Identifying the maximum amount of structural overlap between two different graphs is explored. This topic is particularly relevant in bioinformatics for comparing molecular structures and in pattern recognition within computer vision.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 242,
                column: "TopicDesc",
                value: "Measuring the similarity between graphs is quantified by the 'edit distance'—the minimum number of operations (insert, delete, or substitute) required to transform one graph into another. This is used for robust matching in noisy data environments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 243,
                column: "TopicDesc",
                value: "Assigning labels (colors) to vertices or edges subject to specific constraints is analyzed. Students explore vertex coloring to solve scheduling conflicts and map-making problems, addressing the complexity of finding the 'chromatic number' of a graph.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 244,
                column: "TopicDesc",
                value: "Dual problems in graph theory are examined: 'Packing' (finding the maximum set of disjoint subgraphs) and 'Covering' (finding the minimum set of elements to cover all edges or vertices). This includes the Vertex Cover and Independent Set problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 245,
                column: "TopicDesc",
                value: "The course concludes with a look at modern graph theory applications. Topics may include massive social network analysis, graph neural networks (GNNs) in machine learning, or the application of graph theory to quantum computing and network security.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 246,
                column: "TopicDesc",
                value: "The course begins with an exploration of the CIA triad—Confidentiality, Integrity, and Availability. This module establishes the basic vocabulary of the field, defining threats, vulnerabilities, and risks while outlining the goals of a comprehensive security program.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 247,
                column: "TopicDesc",
                value: "Analysis focuses on the rapidly shifting landscape of cyber threats, including the rise of ransomware-as-a-service, supply chain attacks, and the impact of AI on both offensive and defensive operations. Students examine case studies of recent high-profile breaches to identify modern attack vectors.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 248,
                column: "TopicDesc",
                value: "Fundamental defense strategies are examined, including 'Defense in Depth' and 'Least Privilege.' This section explores the architectural principles used to create resilient systems, such as compartmentalization and the reduction of the attack surface.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 249,
                column: "TopicDesc",
                value: "Security is treated as a business process. This module covers policy development, incident response planning, and disaster recovery. Students learn about the regulatory environment, compliance standards (such as NIST or ISO), and the importance of regular security audits.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 250,
                column: "TopicDesc",
                value: "The human element is often the weakest link in a security chain. This topic addresses social engineering, phishing, and the importance of security awareness training. Students analyze how psychological manipulation is used to bypass technical controls.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 251,
                column: "TopicDesc",
                value: "Mathematical methods for securing data are analyzed. This section covers symmetric and asymmetric encryption, digital signatures, and hash functions. Students explore the Public Key Infrastructure (PKI) and how cryptographic protocols ensure data privacy and authenticity.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 252,
                column: "TopicDesc",
                value: "A secure network requires a deep understanding of the OSI model and TCP/IP stack. This module examines how protocols like DNS, DHCP, and ICMP can be exploited and the fundamental role of packet inspection in identifying malicious traffic.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 253,
                column: "TopicDesc",
                value: "Hardening the environment involves securing servers, workstations, and network devices. This topic covers firewalls, Intrusion Detection Systems (IDS), and Intrusion Prevention Systems (IPS), focusing on how to monitor and protect critical IT assets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 254,
                column: "TopicDesc",
                value: "Verifying identity is central to access control. This module explores Multi-Factor Authentication (MFA), biometric systems, and secure remote access technologies like VPNs and Zero Trust Network Access (ZTNA) to protect data in transit.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 255,
                column: "TopicDesc",
                value: "The unique risks of radio-frequency communication are analyzed. Students learn about the evolution of Wi-Fi security protocols (WEP, WPA2, WPA3), the dangers of rogue access points, and the methods used to secure wireless local area networks (WLANs).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 256,
                column: "TopicDesc",
                value: "Technical defenses are moot without physical protection. This section covers environmental controls, surveillance, hardware locks, and data center security, emphasizing that the physical safety of hardware is the foundation of all digital security.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 257,
                column: "TopicDesc",
                value: "Introduction to the graphics pipeline and the OpenGL state machine. Students learn to set up a rendering context, manage the coordinate system, and understand how the CPU communicates with the GPU to draw simple primitives like points and lines.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 258,
                column: "TopicDesc",
                value: "Mastery of rendering basic geometric shapes and complex rosettes. This module focuses on using loops and mathematical functions to generate vertices for arcs, circles, and polygons, ensuring students understand how to convert abstract geometry into screen pixels.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 259,
                column: "TopicDesc",
                value: "This section explores the software utilities used to manage aspect ratios, window resizing, and viewport mapping. Students learn to maintain visual consistency across different screen resolutions and handle user interaction within the graphics window.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 260,
                column: "TopicDesc",
                value: "Mathematics is the language of graphics. This topic covers the application of vectors, including dot products for lighting calculations and cross products for determining surface normals, providing the essential tools for spatial reasoning in a 3D environment.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 261,
                column: "TopicDesc",
                value: "Manipulation of the visual world is achieved through matrix mathematics. Students implement translation, rotation, and scaling transformations, learning how to concatenate matrices to move objects through local, world, and camera spaces.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 262,
                column: "TopicDesc",
                value: "The beauty of recursive geometry is explored through the generation of fractals. Students learn about self-similarity and L-systems, implementing algorithms like the Mandelbrot set or the Koch snowflake to visualize complex natural patterns through code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 263,
                column: "TopicDesc",
                value: "Optimization techniques are analyzed to achieve high frame rates. This module covers the use of Vertex Buffer Objects (VBOs), display lists, and efficient clipping algorithms to minimize the workload on the GPU and maximize rendering speed.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 264,
                column: "TopicDesc",
                value: "The primary environment for data exploration is introduced. Students learn to use Jupyter’s cell-based structure to combine live Python code, computational output, and rich text documentation, facilitating a reproducible and iterative workflow for visual data analysis.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 265,
                column: "TopicDesc",
                value: "Before choosing a chart, the data must be understood. This module covers the translation of raw datasets into abstract types—Items, Attributes, Links, and Positions—allowing students to identify the underlying structure of the information they intend to visualize.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 266,
                column: "TopicDesc",
                value: "Analysis focuses on how different data types (nominal, ordinal, and quantitative) dictate visual choices. Students explore the mapping of data variables to geometric primitives, ensuring that the chosen representation accurately reflects the mathematical properties of the source data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 267,
                column: "TopicDesc",
                value: "The core philosophy of 'Truth and Beauty' in visualization is examined. Students learn to prioritize the user's task, ensuring that the design facilitates discovery and decision-making while avoiding visual clutter or misleading representations of the data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 268,
                column: "TopicDesc",
                value: "Focusing on clarity in a fixed medium, this topic covers the creation of high-quality plots for reports and publications. Students master the use of alignment, labeling, and contrast to convey a specific narrative without the aid of animation or user interaction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 269,
                column: "TopicDesc",
                value: "Interaction allows users to explore large datasets dynamically. This module introduces techniques like 'Select,' 'Navigate,' and 'Filter,' along with the 'Overview First, Zoom and Filter, Then Details-on-Demand' mantra that guides professional dashboard design.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 270,
                column: "TopicDesc",
                value: "Techniques for visualizing data with more than three variables are explored. Students implement strategies such as Parallel Coordinates, Scatterplot Matrices (SPLOMs), and Heatmaps to uncover correlations in complex, high-dimensional datasets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 271,
                column: "TopicDesc",
                value: "This fundamental topic covers the building blocks of any visualization: 'Marks' (points, lines, areas) and 'Channels' (position, color, size, tilt). Students learn the effectiveness hierarchy of these channels to ensure that the most important data variables are mapped to the most salient visual cues.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 272,
                column: "TopicDesc",
                value: "Students utilize the Seaborn library to create statistically informed visualizations in Python. This section covers high-level interfaces for drawing attractive and informative statistical graphics, integrating seamlessly with Pandas data structures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 273,
                column: "TopicDesc",
                value: "Practical design heuristics are established, such as 'No Unjustified 2D' and 'Eyes Beat Memory.' These rules help students avoid common pitfalls like using 3D effects for 2D data or overloading the user's cognitive capacity with too many simultaneous visual elements.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 274,
                column: "TopicDesc",
                value: "The use of color is examined through the lens of perception. Students learn to choose appropriate colormaps—Categorical, Sequential, or Diverging—while considering accessibility for colorblind users and the psychological impact of different hues.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 275,
                column: "TopicDesc",
                value: "When data has a true spatial component, 3D rendering is utilized. This module addresses the challenges of occlusion and perspective distortion in 3D plots, teaching students how to use lighting and rotation to help users navigate three-dimensional data spaces.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 276,
                column: "TopicDesc",
                value: "Focusing on data that is sampled across a continuous space (like temperature or pressure), this topic covers scalar and vector fields. Students learn techniques such as isolines, volume rendering, and flow visualization to represent scientific and geographic phenomena.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 277,
                column: "TopicDesc",
                value: "Geographic Data (GIS) is explored through Choropleth maps, Proportional Symbol maps, and Cartograms. Students address the challenges of map projections and how to overlay data onto spatial boundaries without introducing geographic bias.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 278,
                column: "TopicDesc",
                value: "Visualizing connectivity and topology is achieved through Node-Link diagrams and Adjacency Matrices. Students learn about force-directed layouts and how to reduce 'hairball' clutter in complex networks to highlight central nodes and communities.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 279,
                column: "TopicDesc",
                value: "Hierarchical data is represented using specialized layouts like Treemaps and Sunburst diagrams. This module focuses on 'space-filling' techniques that allow users to perceive both the structure of the hierarchy and the relative magnitude of the leaves simultaneously.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 280,
                column: "TopicDesc",
                value: "In the intersection of machine learning and visualization, PCA is used to reduce high-dimensional data into a 2D or 3D space. Students implement PCA in Python to project complex datasets onto their most significant axes, facilitating visual cluster discovery.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 281,
                column: "TopicDesc",
                value: "The evolution of HCI is traced from early Command Line Interfaces (CLI) to the Graphical User Interface (GUI) and modern Natural User Interfaces (NUI). Understanding this history provides context for the current paradigms of desktop, web, and mobile interaction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 282,
                column: "TopicDesc",
                value: "UI quality is measured through specific metrics: How quickly can a user learn the system? How fast can an expert perform a task? We analyze the trade-offs between making a system easy for beginners versus powerful for power-users.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 283,
                column: "TopicDesc",
                value: "Drawing from Don Norman’s principles, this module emphasizes 'Affordances' and 'Signifiers.' Students learn to design with the user's mental model in mind, ensuring that the interface provides clear feedback and logical mappings for every action.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 284,
                column: "TopicDesc",
                value: "Designing for human error is essential. This topic covers the prevention of slips and mistakes, the importance of 'Undo' and 'Redo' functionality, and how to write clear, non-punitive error messages that help users recover from problems gracefully.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 285,
                column: "TopicDesc",
                value: "Rapid iteration is explored through Low-Fidelity (paper) and High-Fidelity (digital) prototyping. Students learn how to gather feedback early in the design cycle before committing to expensive software implementation, reducing the risk of project failure.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 286,
                column: "TopicDesc",
                value: "This section covers the methodology for observing real users as they interact with a system. Students learn to conduct 'Think-Aloud' protocols, record qualitative observations, and identify 'pain points' that indicate where a design is failing to meet user needs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 287,
                column: "TopicDesc",
                value: "The technical construction of interfaces is examined, focusing on the Model-View-Controller (MVC) and Model-View-ViewModel (MVVM) patterns. Students learn how to decouple the user interface from the underlying application logic to improve maintainability.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 288,
                column: "TopicDesc",
                value: "Information presentation is addressed through visual and non-visual channels. Analysis covers how the system conveys status and results to the user, including the use of progressive disclosure to manage complex information without overwhelming the screen.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 289,
                column: "TopicDesc",
                value: "Methods for user input are explored, from keyboard and mouse events to touch gestures and voice commands. Students analyze the 'Fitts’s Law' to optimize the size and placement of interactive elements for speed and accuracy.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 290,
                column: "TopicDesc",
                value: "Beyond aesthetics, graphic design is used to communicate structure. This module introduces the 'Gestalt Principles' (Proximity, Similarity, Continuity), teaching students how to use visual groupings to imply relationships between different interface elements.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 291,
                column: "TopicDesc",
                value: "The fine details of the UI are mastered. Students explore grid systems for layout, the use of color for branding and status signaling, and the impact of typography on readability and the 'scannability' of digital interfaces.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 292,
                column: "TopicDesc",
                value: "Expert-based inspection is taught using Nielsen’s 10 Usability Heuristics. Students learn to audit an interface for common issues, such as lack of consistency or poor visibility of system status, providing a fast alternative to full-scale user testing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 293,
                column: "TopicDesc",
                value: "Designing for all users is a legal and ethical requirement. This section covers WCAG standards, screen reader compatibility, and high-contrast modes, ensuring that interfaces are usable by individuals with visual, motor, or cognitive impairments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 294,
                column: "TopicDesc",
                value: "Preparing software for a global market involves more than just translation. This topic covers 'i18n' practices, including handling different date formats, currency symbols, and text expansion/contraction to ensure the UI remains functional across different cultures.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 295,
                column: "TopicDesc",
                value: "The course begins with the OSI and TCP/IP models, establishing the concept of protocol layering. Students explore the physical and logical structures of networks, the roles of standards bodies like IEEE and IETF, and the fundamental mechanics of data encapsulation and decapsulation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 296,
                column: "TopicDesc",
                value: "Focusing on the Data Link Layer, this module examines how data is framed and transmitted over physical media. Topics include error detection and correction (CRC), flow control, and Medium Access Control (MAC) protocols used in Ethernet and wireless local area networks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 297,
                column: "TopicDesc",
                value: "The Network Layer is explored through IP addressing and packet forwarding. Students analyze the role of routers, the differences between IPv4 and IPv6, and the mechanics of the Address Resolution Protocol (ARP) to understand how data navigates across different network boundaries.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 298,
                column: "TopicDesc",
                value: "This section delves into complex routing architectures and protocols such as OSPF and BGP. Analysis includes the global hierarchical structure of the internet, autonomous systems, and the algorithms used to determine the most efficient paths for data traffic.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 299,
                column: "TopicDesc",
                value: "The Transport Layer is examined via TCP and UDP. Students analyze the three-way handshake, port numbering, and the delivery guarantees provided by connection-oriented protocols versus the speed-oriented nature of connectionless protocols.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 300,
                column: "TopicDesc",
                value: "Maintaining network stability requires managing traffic flow to prevent bottlenecks. This module covers TCP congestion window management, additive increase/multiplicative decrease (AIMD) logic, and techniques for detecting and responding to network saturation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 301,
                column: "TopicDesc",
                value: "The course concludes with an overview of protecting data in transit. Topics include the implementation of firewalls, Virtual Private Networks (VPNs), and cryptographic protocols like TLS/SSL that ensure confidentiality and integrity across the network infrastructure.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 302,
                column: "TopicDesc",
                value: "The initial phase of an attack involves gathering information about the target. Students explore passive and active techniques to map an organization's digital footprint, including social engineering and identifying publicly available information without direct system interaction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 303,
                column: "TopicDesc",
                value: "This module focuses on identifying entry points by gathering data on open ports, services, and system versions. Using tools like Nmap, students learn to extract usernames, hostnames, and network shares to prepare for deeper vulnerability assessments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 304,
                column: "TopicDesc",
                value: "Students learn to systematically identify weaknesses in software and configurations. This section covers the use of automated scanners and manual analysis to correlate discovered services with known CVEs (Common Vulnerabilities and Exposures).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 305,
                column: "TopicDesc",
                value: "The 'Proof of Concept' phase: students safely attempt to leverage identified vulnerabilities to bypass security controls. The focus is on understanding the mechanics of an exploit and the risks associated with executing unauthorized code on a target system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 306,
                column: "TopicDesc",
                value: "This topic explores the transition from external probe to internal system access. Students examine techniques for bypassing authentication, including credential harvesting and session hijacking, to establish an initial foothold within the target network.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 307,
                column: "TopicDesc",
                value: "Once inside, an attacker seeks higher authority. This module covers moving from a standard user to an administrative or 'root' level account by exploiting misconfigurations, kernel vulnerabilities, or insecure service permissions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 308,
                column: "TopicDesc",
                value: "Analysis of what an attacker can do once control is established. Students learn to navigate the target system, identify high-value data, and perform lateral movement to access other machines on the same network.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 309,
                column: "TopicDesc",
                value: "Students explore how attackers maintain long-term access using backdoors and rootkits. The module also covers the defensive counter-measure of log analysis, teaching how attackers attempt to delete or alter logs to hide their presence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 310,
                column: "TopicDesc",
                value: "Focusing on the application layer, this section examines how to intercept and modify HTTP traffic. Students analyze web requests and responses to find flaws in business logic and session management.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 311,
                column: "TopicDesc",
                value: "Mastery of the industry-standard tool for web application security testing. Students learn to use the proxy, repeater, and intruder modules to automate the discovery and exploitation of web-based vulnerabilities.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 312,
                column: "TopicDesc",
                value: "One of the most dangerous vulnerabilities: students learn how to inject malicious SQL queries into input fields to manipulate backend databases, bypass logins, and extract sensitive information like passwords and user data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 313,
                column: "TopicDesc",
                value: "Client-side attacks are explored, including how to inject malicious scripts into trusted websites (XSS) and how to trick users into performing unauthorized actions (CSRF) on applications where they are currently authenticated.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 314,
                column: "TopicDesc",
                value: "Students examine the behavior and impact of malicious software. This module covers static and dynamic analysis of viruses, worms, and trojans, focusing on how malware spreads and communicates with Command and Control (C2) servers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 315,
                column: "TopicDesc",
                value: "The attack surface is expanded to include modern environments. Students analyze the security flaws inherent in WPA2/3, misconfigured cloud storage buckets, and the often-unsecured firmware of Internet of Things devices.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 316,
                column: "TopicDesc",
                value: "The course explores the future of security, examining how Large Language Models and machine learning are used to automate vulnerability discovery and craft more sophisticated phishing attacks, as well as their role in defensive threat detection.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 317,
                column: "TopicDesc",
                value: "The final deliverable of an ethical hack: the professional report. Students learn to document their findings with screenshots and logs, categorize risks using the CVSS scale, and provide actionable remediation steps for technical and executive audiences.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 318,
                column: "TopicDesc",
                value: "The module introduces the 'Five Vs' of Big Data (Volume, Velocity, Variety, Veracity, and Value). Analysis focuses on the shift from traditional database processing to distributed systems required to handle the massive scale of modern data ecosystems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 319,
                column: "TopicDesc",
                value: "Data is classified into nominal, ordinal, interval, and ratio scales. Understanding these types is critical for selecting the correct statistical operations and mining algorithms that respect the mathematical properties of the data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 320,
                column: "TopicDesc",
                value: "This section explores data characteristics such as distinctness, order, and meaningfulness of zero. Students learn how these properties influence the way data is stored and compared during the discovery phase.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 321,
                column: "TopicDesc",
                value: "Beyond simple tables, this topic addresses diverse data structures including record data, graph-based data (like social networks), ordered data (time series), and spatial data, highlighting the unique mining challenges each presents.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 322,
                column: "TopicDesc",
                value: "The 'Garbage In, Garbage Out' principle is examined. Students learn to identify issues such as noise, outliers, missing values, and duplicate data that can skew mining results if not addressed early in the KDD process.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 323,
                column: "TopicDesc",
                value: "When processing the entire dataset is impossible, statistical sampling techniques are used. This module covers simple random sampling, stratified sampling, and progressive sampling to ensure the subset remains representative of the whole.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 324,
                column: "TopicDesc",
                value: "To prevent attributes with large ranges from dominating others, data is scaled. This section covers Min-Max scaling and Z-score standardization, ensuring that features like 'Salary' and 'Age' are treated fairly by distance-based algorithms.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 325,
                column: "TopicDesc",
                value: "The practical phase of KDD: students implement strategies to fill in missing values, smooth noisy data, and resolve inconsistencies. This module emphasizes the role of domain knowledge in making decisions about data correction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 326,
                column: "TopicDesc",
                value: "The foundation of clustering and classification. This topic covers mathematical distances, including Euclidean, Manhattan, and Cosine similarity, teaching students how to quantify the 'closeness' of two data objects.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 327,
                column: "TopicDesc",
                value: "Dimensionality reduction is achieved by identifying the most relevant attributes. Students learn to use filters and wrappers to eliminate redundant or irrelevant features, improving both model accuracy and computational speed.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 328,
                column: "TopicDesc",
                value: "Unlike feature selection, this focuses on reducing the number of rows (records). Students explore techniques to keep only the most informative data points, which is essential for training models on massive datasets with limited memory.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 329,
                column: "TopicDesc",
                value: "Mining results are communicated through visual means. This module covers the use of scatter plots, histograms, and heatmaps to reveal clusters, trends, and outliers that might be hidden in raw numerical output.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 330,
                column: "TopicDesc",
                value: "Instruction focuses on the ethical and technical methods of gathering data, from web scraping to API integration. Students analyze the challenges of aggregating data from disparate sources into a unified data warehouse.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 331,
                column: "TopicDesc",
                value: "Market Basket Analysis is explored through the Apriori algorithm. Students learn to find frequent itemsets and generate association rules (e.g., 'If a customer buys bread, they are 80% likely to buy milk').");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 332,
                column: "TopicDesc",
                value: "Not all patterns are useful. This section covers objective measures like Support, Confidence, and Lift, helping students distinguish between statistically significant rules and random coincidences.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 333,
                column: "TopicDesc",
                value: "Unsupervised learning is introduced as a way to find natural groupings in data. The module explores the fundamental goal of maximizing intra-cluster similarity while minimizing inter-cluster similarity.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 334,
                column: "TopicDesc",
                value: "A 'lazy' learning approach where new data is classified based on the majority vote of its closest neighbors. Students analyze how the choice of 'K' impacts the sensitivity of the model to noise and local patterns.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 335,
                column: "TopicDesc",
                value: "The most common partitioning-based clustering method. Students implement the iterative process of assigning points to centroids and recalculating those centroids until the system reaches stability (convergence).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 336,
                column: "TopicDesc",
                value: "To ensure models generalize well to new data, students use K-fold cross-validation. This module teaches how to split data into training and testing sets to provide a more reliable estimate of a model's real-world performance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 337,
                column: "TopicDesc",
                value: "In cases of imbalanced data, accuracy is misleading. Students learn to calculate the F1-Score—the harmonic mean of Precision and Recall—to evaluate how well a model handles both false positives and false negatives.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 338,
                column: "TopicDesc",
                value: "Inspired by biological neurons, this module introduces the artificial neuron. Students learn about weights, biases, and activation functions, forming the mathematical basis for how machines learn from complex input patterns.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 339,
                column: "TopicDesc",
                value: "The industry-standard language is utilized for implementation. Students leverage libraries such as NumPy for matrix math, Pandas for data manipulation, and Scikit-learn for building and evaluating predictive models.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 340,
                column: "TopicDesc",
                value: "Using the Weka software suite, students perform rapid prototyping of ML algorithms. This GUI-based tool allows for easy data preprocessing, attribute selection, and the comparison of different classification models without writing extensive code.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 341,
                column: "TopicDesc",
                value: "This section focuses on statistically significant comparisons between algorithms. Students set up large-scale experiments to test multiple models across diverse datasets, analyzing the results to determine which learners perform best.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 342,
                column: "TopicDesc",
                value: "Data mining workflows are visualized. Students use Weka’s KnowledgeFlow interface to create stream-oriented layouts, connecting data sources to filters, classifiers, and evaluation tools in a visual pipeline.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 343,
                column: "TopicDesc",
                value: "The course establishes the foundational concepts of Supervised, Unsupervised, and Reinforcement learning. Students analyze the different feedback loops used to train models and the types of problems each paradigm is best suited to solve.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 344,
                column: "TopicDesc",
                value: "A rigorous mathematical notation is established. Students master the vector and matrix representations of data (tensors), ensuring they can read and implement algorithms from academic research papers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 345,
                column: "TopicDesc",
                value: "The simplest form of a neural network: a single-layer linear classifier. Students learn how the perceptron makes decisions and how it is limited to solving 'linearly separable' problems (like the AND/OR gates but not XOR).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 346,
                column: "TopicDesc",
                value: "Analysis of the transition from single neurons to massive, interconnected architectures. This topic covers feedforward structures and the role of hidden layers in capturing high-level features from raw data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 347,
                column: "TopicDesc",
                value: "The mathematical proof that if a problem is linearly separable, the perceptron learning algorithm is guaranteed to find a solution in a finite number of steps. This module explores the boundary of what simple learners can achieve.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 348,
                column: "TopicDesc",
                value: "By adding hidden layers, networks can solve non-linear problems. Students explore the architecture of the MLP, where information flows through multiple stages of transformation to reach a final classification or prediction.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 349,
                column: "TopicDesc",
                value: "The core optimization algorithm of ML. Students learn how to calculate the 'slope' of the error surface and iteratively adjust weights in the direction that minimizes the loss function, effectively 'descending' the mountain of error.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 350,
                column: "TopicDesc",
                value: "The engine of deep learning: errors are calculated at the output and 'propagated backward' through the network using the chain rule of calculus. This allows the network to assign 'blame' to specific weights and adjust them accordingly.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 351,
                column: "TopicDesc",
                value: "A model that memorizes training data but fails on new data is 'overfit.' Students learn to identify this through learning curves and explore solutions like regularization, dropout, and early stopping to ensure the model generalizes well.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 352,
                column: "TopicDesc",
                value: "Engineering the architecture: students explore how many layers to include, which activation functions to use (Sigmoid, Tanh, ReLU), and how to initialize weights to ensure the network trains efficiently.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 353,
                column: "TopicDesc",
                value: "Theoretical proof that a feedforward network with a single hidden layer can approximate any continuous function to any desired degree of accuracy. This module explains why neural networks are such powerful universal tools.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 354,
                column: "TopicDesc",
                value: "Predicting a label (spam or not) versus predicting a continuous value (house price). Students learn to modify the output layer and loss functions (Cross-Entropy vs MSE) to switch between these two primary ML tasks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 355,
                column: "TopicDesc",
                value: "Handling data where the order matters (stock prices, weather). Students analyze how to structure windowed data for standard ML models and the need for temporal awareness in predictive systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 356,
                column: "TopicDesc",
                value: "Specific to CI & ML, this covers handling categorical variables through one-hot encoding and scaling inputs to ensure the Gradient Descent algorithm doesn't oscillate or fail to converge.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 357,
                column: "TopicDesc",
                value: "A different approach to intelligence inspired by Darwinian evolution. Students explore 'Survival of the Fittest' algorithms that use selection, crossover, and mutation to evolve solutions to complex optimization problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 358,
                column: "TopicDesc",
                value: "Practical use of GAs in scheduling, feature selection, and neural network weight optimization. This section highlights how evolutionary methods can find global optima where gradient-based methods might get stuck in local minima.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 359,
                column: "TopicDesc",
                value: "The mathematical foundation of Genetic Algorithms. Holland's Schemata Theorem is analyzed to explain how 'building blocks' of good solutions are preserved and propagated through generations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 360,
                column: "TopicDesc",
                value: "Learning Vector Quantization: a supervised version of competitive learning. Students learn how this algorithm represents classes by a set of 'codebook vectors' in the feature space, adjusting them to move toward correct classifications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 361,
                column: "TopicDesc",
                value: "Self-Organizing Maps: an unsupervised neural network that produces a low-dimensional (typically 2D) representation of the input space. Students learn how SOMs are used for visualizing the topology of high-dimensional data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 362,
                column: "TopicDesc",
                value: "The course concludes by applying CI techniques to grouping data. Students analyze how neural and evolutionary methods provide different perspectives on cluster discovery compared to traditional statistical methods like K-Means.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 363,
                column: "TopicDesc",
                value: "The course begins with the industry-standard IDE for Android development. Students master the project structure, the Gradle build system, and the Java-based Activity lifecycle, learning how to manage application states from initialization to background execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 364,
                column: "TopicDesc",
                value: "Modern mobile apps require real-time capabilities. This module introduces Google's Firebase platform, focusing on its Backend-as-a-Service (BaaS) features including Realtime Database, Authentication, and Cloud Messaging to support dynamic user experiences.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 365,
                column: "TopicDesc",
                value: "Students explore the use of Extensible Markup Language (XML) to define the structural blueprint of mobile interfaces. This section covers how XML separates the visual presentation layer from the underlying Java logic for better maintainability.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 366,
                column: "TopicDesc",
                value: "Focusing on responsive UI, this topic covers ConstraintLayout, LinearLayout, and FrameLayout. Students learn to create adaptive interfaces that remain functional and visually appealing across various screen sizes and device orientations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 367,
                column: "TopicDesc",
                value: "Beyond standard coding, students apply professional architectural patterns to mobile development. This module explores Singleton, Factory, and Observer patterns to ensure the codebase remains scalable and testable.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 368,
                column: "TopicDesc",
                value: "This section delves into cloud-based data management. Analysis focuses on the NoSQL structure of Firebase Firestore, teaching students how to structure JSON-like documents and collections for efficient mobile querying and synchronization.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 369,
                column: "TopicDesc",
                value: "To map out complex application logic, students utilize Control Flow Diagrams. These visual tools help in auditing the paths a user can take through the app, ensuring all logical branches and edge cases are accounted for.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 370,
                column: "TopicDesc",
                value: "The Model-View-Controller (MVC) pattern is mastered to decouple data processing from the user interface. This separation allows students to update the app's look or its data handling independently without breaking the system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 371,
                column: "TopicDesc",
                value: "DFDs are used to track how information moves from the user interface into the backend database. This module helps students identify external entities, data stores, and the transformation processes within their mobile systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 372,
                column: "TopicDesc",
                value: "Applying HCI principles, this topic focuses on mobile-specific usability. Students learn to implement intuitive navigation, clear affordances, and feedback loops that meet modern 'Material Design' standards for accessibility and ease of use.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 373,
                column: "TopicDesc",
                value: "The course establishes Python as a scientific powerhouse. Students learn to use NumPy for high-performance vectorized operations, replacing slow loops with efficient array-based computations essential for large-scale numerical work.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 374,
                column: "TopicDesc",
                value: "Using libraries like SymPy, students perform algebraic manipulations programmatically. This includes symbolic differentiation, integration, and the simplification of complex mathematical expressions before numerical evaluation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 375,
                column: "TopicDesc",
                value: "Visual communication of data is mastered using Matplotlib and Pyplot. Students learn to create publication-quality figures, including 2D plots, histograms, and 3D surfaces to interpret the results of their computational models.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 376,
                column: "TopicDesc",
                value: "This section addresses both linear and non-linear root-finding. Students implement numerical solvers like the Newton-Raphson method and bisection algorithms to find solutions for complex equations that cannot be solved analytically.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 377,
                column: "TopicDesc",
                value: "Focusing on finding the minima or maxima of functions, this module explores SciPy's optimization suite. Students learn to apply gradient-based and heuristic methods to solve engineering and resource allocation problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 378,
                column: "TopicDesc",
                value: "When data is sampled at discrete points, interpolation is used to estimate unknown values. Students explore linear, polynomial, and spline interpolation to create smooth curves and fill gaps in experimental datasets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 379,
                column: "TopicDesc",
                value: "Numerical integration techniques, such as the Trapezoidal rule and Simpson's rule, are examined. This topic covers the calculation of definite integrals for functions that are only known at discrete data points or are too complex for traditional calculus.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 380,
                column: "TopicDesc",
                value: "Large systems often contain mostly zero values. This module teaches memory-efficient storage formats for sparse matrices and their application in solving large linear systems and modeling network-based graph problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 381,
                column: "TopicDesc",
                value: "Utilizing the Pandas library, students learn to clean, transform, and aggregate large datasets. The focus is on 'Wrangling' messy scientific data into a structured format suitable for statistical modeling and hypothesis testing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 382,
                column: "TopicDesc",
                value: "This section covers the transition from raw data to probabilistic insights. Students implement linear and multiple regression models, learn about p-values, and analyze the significance of correlations within their computational experiments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 383,
                column: "TopicDesc",
                value: "Scientific computing meets AI: students apply Scikit-learn to perform classification and regression. The focus is on using these models as predictive tools to uncover patterns in high-dimensional scientific datasets.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 384,
                column: "TopicDesc",
                value: "The course concludes with the Bayesian approach to probability. Students learn to use prior knowledge and likelihood to update the probability of a hypothesis (Bayes' Theorem), applying it to parameter estimation and risk analysis.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 386,
                column: "TopicDesc",
                value: "Students explore the integration of digital information with the user's real-world environment. This module covers the fundamental technology behind AR, including optical see-through displays, spatial mapping, and the alignment of virtual objects with physical geometry.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 387,
                column: "TopicDesc",
                value: "The spectrum between the physical and virtual worlds is examined. Analysis focuses on environments where physical and digital objects co-exist and interact in real-time, requiring advanced spatial anchoring and occlusion techniques.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 388,
                column: "TopicDesc",
                value: "The module covers fully immersive, computer-generated environments. Students study the hardware and software requirements for achieving 'presence'—the psychological sensation of being inside the virtual world—through stereoscopic rendering and head tracking.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 389,
                column: "TopicDesc",
                value: "An umbrella term for VR, AR, and MR. This section discusses the converging future of these technologies (XR) and the cross-platform development challenges associated with creating content for a diverse range of immersive hardware.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 390,
                column: "TopicDesc",
                value: "Utilizing the Unity 3D engine and C#, students learn the technical implementation of VR. This includes managing 3D assets, handling specialized VR input (like gaze and controllers), and optimizing frame rates to prevent motion sickness.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 391,
                column: "TopicDesc",
                value: "This topic addresses the limitations and ethical concerns of VR, including simulator sickness, latency issues, privacy in virtual spaces, and the social impact of long-term immersion in simulated environments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 392,
                column: "TopicDesc",
                value: "The principles of HCI are applied to 3D spaces. Students explore 3D selection, manipulation, and navigation techniques, focusing on how to design intuitive interfaces when traditional 2D metaphors (like mice and menus) are no longer sufficient.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 393,
                column: "TopicDesc",
                value: "Quantitative and qualitative metrics for VR are analyzed. Students learn to measure user performance (task time, error rate) and subjective experiences (immersion, workload using NASA-TLX) to evaluate the effectiveness of a VR system.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 394,
                column: "TopicDesc",
                value: "Students analyze current academic literature to understand the state-of-the-art in VR. This involves identifying research gaps and understanding the evolution of VR applications in medicine, education, and industry.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 395,
                column: "TopicDesc",
                value: "Formal research methodology is taught. Students learn how to structure a study, define independent and dependent variables, and create counterbalanced procedures to minimize bias in human-subject experiments.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 396,
                column: "TopicDesc",
                value: "The course culminates in the practical application of research. Students design and build a VR environment specifically for an experiment, ensuring the software reliably logs the data needed to answer a specific HCI research question.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 397,
                column: "TopicDesc",
                value: "The foundation of data science is established. This module covers descriptive statistics, including central tendency and dispersion, and introduces the frequentist approach to probability that underpins standard statistical testing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 398,
                column: "TopicDesc",
                value: "The process of inspecting, cleansing, and modeling data is explored. Students learn to use computational tools to extract meaningful information and support decision-making through systematic data exploration.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 399,
                column: "TopicDesc",
                value: "This section bridges basic concepts with advanced theory. It covers the logic of p-values, confidence intervals, and the importance of effect size in determining the practical significance of research findings.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 400,
                column: "TopicDesc",
                value: "Students master the R programming language, the industry standard for statistical computing. This includes data frame manipulation, package management (CRAN), and writing custom functions for automated data processing.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 401,
                column: "TopicDesc",
                value: "Visual analytics are performed using tools like ggplot2. Students learn to create boxplots, histograms, and scatter plots to identify distributions, outliers, and trends before performing formal statistical tests.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 402,
                column: "TopicDesc",
                value: "Before running tests, data must meet specific criteria. This module focuses on testing for normality and homogeneity of variance, teaching students how to diagnose and correct violations using data transformations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 403,
                column: "TopicDesc",
                value: "The relationship between variables is quantified. Students calculate Pearson's and Spearman's correlation coefficients, learning how to interpret the strength and direction of associations in both parametric and non-parametric data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 404,
                column: "TopicDesc",
                value: "Predictive modeling is introduced. Students implement simple and multiple linear regression to model the relationship between a dependent variable and one or more predictors, focusing on the R-squared value and residuals analysis.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 405,
                column: "TopicDesc",
                value: "When the outcome is categorical (e.g., success/failure), logistic regression is applied. Students learn to interpret odds ratios and use the model for classification tasks in diverse computing scenarios.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 406,
                column: "TopicDesc",
                value: "Statistical comparison of groups is performed using t-tests and ANOVA. Students learn to determine if differences between sample means are statistically significant or the result of random chance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 407,
                column: "TopicDesc",
                value: "Students explore how two variables change together. This topic covers the variance-covariance matrix and its essential role in multivariate analysis and the understanding of shared variance in complex models.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 408,
                column: "TopicDesc",
                value: "The course emphasizes the scientific method. Students learn to construct null and alternative hypotheses, choose appropriate statistical tests, and interpret results to draw valid conclusions from raw data.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 409,
                column: "TopicDesc",
                value: "An introduction to the role of the OS as a resource manager and extended machine. Students explore the kernel-user mode abstraction, system calls, and the historical evolution of batch, time-sharing, and real-time systems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 410,
                column: "TopicDesc",
                value: "A comparative analysis of modern OS architectures, including Windows, Linux, and macOS. Focus is placed on how these systems handle monolithic versus microkernel designs and their specific approaches to abstraction and security.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 411,
                column: "TopicDesc",
                value: "Instruction focuses on the philosophy of 'everything is a file.' Students learn the basics of the UNIX shell, file permissions, and the powerful command-line tools that form the backbone of server administration and DevOps.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 412,
                column: "TopicDesc",
                value: "The core unit of work is examined. This module covers process creation (fork/exec), states (Ready, Running, Waiting), and the Process Control Block (PCB). Students analyze how the OS maintains isolation between different running programs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 413,
                column: "TopicDesc",
                value: "Lightweight processes are explored as the basis for modern concurrent programming. Students analyze the differences between user-level and kernel-level threads, focusing on shared memory, synchronization challenges, and multi-core utilization.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 414,
                column: "TopicDesc",
                value: "Analysis of algorithms that decide which process runs next. Students compare First-Come-First-Served (FCFS), Shortest-Job-First (SJF), Round Robin, and Priority scheduling, evaluating them based on throughput, turnaround time, and fairness.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 415,
                column: "TopicDesc",
                value: "Management of the physical RAM. Topics include logical versus physical addressing, swapping, and contiguous allocation. A significant focus is placed on Paging and Segmentation as methods to eliminate external fragmentation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 416,
                column: "TopicDesc",
                value: "The module covers the physical structure of secondary storage (HDDs and SSDs). Students learn about disk scheduling algorithms (SCAN, C-SCAN, LOOK) and the implementation of RAID levels to ensure data reliability and performance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 417,
                column: "TopicDesc",
                value: "The logical view of storage is analyzed. Students explore directory structures, file access methods (sequential vs. direct), and the mapping of logical file blocks to physical disk sectors, including the role of the Virtual File System (VFS).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 418,
                column: "TopicDesc",
                value: "Defining the components of optimization: the objective function, decision variables, and constraints. Students learn to classify problems based on their mathematical structure and the nature of the search space.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 419,
                column: "TopicDesc",
                value: "A study of variables that are integers versus those that can take any real value. Students analyze how the nature of the variable dictates the choice of algorithm, such as Gradient Descent for continuous spaces vs. Branch and Bound for discrete ones.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 420,
                column: "TopicDesc",
                value: "Focusing on problems where the set of feasible solutions is discrete or can be reduced to discrete. Classic examples like the Traveling Salesperson Problem (TSP) and Knapsack problem are used to demonstrate the challenges of exponential search spaces.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 421,
                column: "TopicDesc",
                value: "When multiple goals conflict (e.g., maximizing speed while minimizing cost), there is no single best solution. Students learn about Pareto Optimality and how to find a set of 'best compromise' solutions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 422,
                column: "TopicDesc",
                value: "Addressing uncertainty: this module covers methods for optimizing functions that involve random variables. Students learn to find solutions that are robust to noise and varying environmental conditions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 423,
                column: "TopicDesc",
                value: "A fundamental regression and optimization technique. Students use calculus to minimize the sum of the squares of the residuals, providing a best-fit solution for over-determined systems in data science and engineering.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 424,
                column: "TopicDesc",
                value: "Mastering the Simplex method and Duality. Students learn to solve problems where the objective function and all constraints are linear, a staple of operations research and logistics.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 425,
                column: "TopicDesc",
                value: "A critical subset of optimization where any local minimum is also a global minimum. Students analyze the properties of convex sets and functions, ensuring efficient and guaranteed convergence in machine learning applications.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 426,
                column: "TopicDesc",
                value: "Moving beyond straight lines: this section addresses curves and complex surfaces. Students explore the Karush-Kuhn-Tucker (KKT) conditions and iterative methods like the Newton-Raphson and Quasi-Newton algorithms.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 427,
                column: "TopicDesc",
                value: "The 'Peak' problem: students analyze why algorithms often get stuck in local optima (small hills) and the strategies required to find the true global optimum (the highest mountain) in a complex landscape.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 428,
                column: "TopicDesc",
                value: "Simple iterative algorithms that move in the direction of increasing value. Students learn the 'Greedy' nature of these searches and identify when they are likely to fail due to plateaus or ridges.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 429,
                column: "TopicDesc",
                value: "A meta-heuristic that uses memory to avoid getting stuck. By keeping a 'Tabu list' of recently visited states, the algorithm is forced to explore new areas of the search space, preventing cycles and local entrapment.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 430,
                column: "TopicDesc",
                value: "Inspired by metallurgy, this algorithm allows 'downhill' moves early in the search to escape local optima. As the 'temperature' cools, the search becomes more selective, eventually settling into a high-quality global solution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 431,
                column: "TopicDesc",
                value: "Using repeated random sampling to obtain numerical results. This module covers how randomness can be used to solve deterministic problems that are otherwise too difficult to compute exactly.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 432,
                column: "TopicDesc",
                value: "Borrowing from biology, these use selection, crossover, and mutation on a population of solutions. Students evolve better answers over generations, applying the 'Survival of the Fittest' principle to complex design problems.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 433,
                column: "TopicDesc",
                value: "Inspired by bird flocking and fish schooling. Particles move through the search space, influenced by their own best-known position and the best position found by the entire swarm, leading to rapid convergence on global optima.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 434,
                column: "TopicDesc",
                value: "A swarm-based meta-heuristic mimicking the foraging behavior of honey bees. Students analyze the roles of employed bees, onlookers, and scouts in balancing the exploration and exploitation of the search space.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 435,
                column: "TopicDesc",
                value: "Based on the flashing behavior of fireflies. The algorithm uses the concept of 'brightness' (objective value) and 'attractiveness' to move solutions toward one another, naturally clustering them around optimal regions.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 436,
                column: "TopicDesc",
                value: "A look at modern bio-inspired algorithms. The Whale algorithm mimics 'bubble-net' hunting, while the Grasshopper algorithm models the social interaction and repulsion/attraction forces of swarming insects.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 437,
                column: "TopicDesc",
                value: "A powerful population-based stochastic function optimizer. Students learn how DE uses the vector difference between existing solutions to disturb the population, providing a robust and fast search mechanism for continuous spaces.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 438,
                column: "TopicDesc",
                value: "The course begins by addressing the 'Power Wall' and the limits of single-core frequency scaling. Students analyze why parallelization is essential for big data, real-time simulations, and the continued advancement of Moore’s Law.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 439,
                column: "TopicDesc",
                value: "An examination of Flynn’s Taxonomy (SISD, SIMD, MISD, MIMD). Students learn the architectural differences between shared-memory systems (Symmetric Multiprocessing) and distributed-memory systems (Clusters).");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 440,
                column: "TopicDesc",
                value: "Students master directive-based parallel programming for shared memory. This module covers thread creation, work-sharing constructs like 'parallel for,' and the management of critical sections to prevent data races.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 441,
                column: "TopicDesc",
                value: "Focusing on GPGPU (General-Purpose computing on Graphics Processing Units), students write kernels in CUDA to manage thousands of concurrent threads, exploring the memory hierarchy of the GPU and warp execution.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 442,
                column: "TopicDesc",
                value: "For distributed systems where memory is not shared, students use the Message Passing Interface (MPI). This section covers point-to-point communication, collective operations like 'Broadcast' and 'Reduce,' and communicator management.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 443,
                column: "TopicDesc",
                value: "Students learn to quantify the success of parallelization using Amdahl’s Law and Gustafson’s Law. Analysis focuses on speedup, efficiency, and identifying bottlenecks caused by communication overhead or load imbalance.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 444,
                column: "TopicDesc",
                value: "Advanced algorithmic strategies for search problems. Students learn how to distribute state-space trees across multiple processors to solve complex combinatorial problems like the N-Queens or Traveling Salesperson faster.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 445,
                column: "TopicDesc",
                value: "This module explores recursive parallelism. Students learn to implement parallel versions of classic algorithms, focusing on how to efficiently spawn tasks and merge results without creating excessive synchronization overhead.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 446,
                column: "TopicDesc",
                value: "Analysis of parallelized Quicksort, Mergesort, and Bitonic sort. Students explore how data movement between processors often becomes the primary cost factor in large-scale parallel sorting operations.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 447,
                column: "TopicDesc",
                value: "Instruction focuses on how modern machine learning models (like Deep Learning) rely on parallel matrix operations. Students explore the scaling of training algorithms across multiple nodes and GPUs.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 448,
                column: "TopicDesc",
                value: "The course concludes with the application of parallel techniques to scientific simulations. Students analyze how parallelization enables high-fidelity modeling in fields such as weather prediction, genomics, and physics.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 449,
                column: "TopicDesc",
                value: "A comparative study of process models including Waterfall, V-Model, and Agile (Scrum/Kanban). Students analyze which methodology best suits different project constraints, team sizes, and client requirements.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 450,
                column: "TopicDesc",
                value: "The business of engineering: students learn to use Gantt charts and PERT diagrams to estimate timelines, allocate resources, and manage risks before a single line of code is written.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 451,
                column: "TopicDesc",
                value: "Focusing on the 'What' before the 'How.' Students master the creation of Software Requirements Specifications (SRS), utilizing use-case diagrams to define system boundaries and functional requirements.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 452,
                column: "TopicDesc",
                value: "Architectural planning: students explore high-level system design, including modularity, coupling, and cohesion. This module emphasizes creating a robust technical blueprint that guides the implementation phase.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 453,
                column: "TopicDesc",
                value: "Quality assurance is examined through Unit, Integration, and System testing. Students learn to write test plans that cover both black-box (functional) and white-box (structural) validation techniques.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 454,
                column: "TopicDesc",
                value: "The transition from design to code. This topic covers coding standards, version control (Git), and the importance of documentation in ensuring that the software remains maintainable throughout its lifecycle.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 455,
                column: "TopicDesc",
                value: "Students interact with 'clients' to elicit and validate requirements. This module focuses on resolving ambiguities and translating vague user needs into a concrete, technical project scope.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 456,
                column: "TopicDesc",
                value: "The practical application of system architecture. Students design the database schemas, API contracts, and user interfaces for their specific project, justifying their technology stack choices to the faculty.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 457,
                column: "TopicDesc",
                value: "Utilizing UML diagrams and prototypes to visualize the system. Students create class diagrams, sequence diagrams, and wireframes to communicate their design effectively to stakeholders before implementation.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 458,
                column: "TopicDesc",
                value: "The primary build phase: students work in teams using modern languages like Java or Python to develop their library, tool, or application, adhering to the design specifications created in earlier weeks.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 459,
                column: "TopicDesc",
                value: "Rigorous debugging and verification. Students perform user acceptance testing (UAT) and regression testing to ensure their final product is stable and meets the original requirement specification.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 460,
                column: "TopicDesc",
                value: "Communication skills are tested through a formal oral defense. Students present their project’s architecture, challenges, and results to a panel, demonstrating both technical mastery and professional poise.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 461,
                column: "TopicDesc",
                value: "Students analyze the ethical dilemmas posed by AI, facial recognition, and autonomous systems. Discussion focuses on algorithmic bias, data privacy, and the 'Black Box' problem in modern machine learning.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 462,
                column: "TopicDesc",
                value: "An examination of the ACM and IEEE Codes of Ethics. Students learn about the professional obligations of a software engineer, including public safety, honesty, and the responsibility to maintain technical competence.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 463,
                column: "TopicDesc",
                value: "This section explores how computing has reshaped human interaction, labor, and democracy. Topics include the digital divide, the impact of social media on discourse, and the role of tech in global development.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 464,
                column: "TopicDesc",
                value: "Analysis of the legal and social aspects of cybercrime. Students explore the motivations behind hacking, identity theft, and denial-of-service attacks, and the legal frameworks (like the CFAA) used to prosecute them.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 465,
                column: "TopicDesc",
                value: "A study of Intellectual Property in the digital age. Students debate the ethics of file sharing, the impact of piracy on the software industry, and the evolution of Digital Rights Management (DRM) technologies.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 466,
                column: "TopicDesc",
                value: "The module covers the legal mechanisms for protecting software. Students learn the differences between copyrighting code and patenting algorithms, and the role of Open Source licenses in the modern tech ecosystem.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 467,
                column: "TopicDesc",
                value: "Technology is borderless. This topic addresses international issues such as offshoring, global data privacy standards (GDPR), and the environmental impact of electronic waste and energy-intensive data centers.");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 468,
                column: "TopicDesc",
                value: "The course concludes with a focus on the ethical dimension of security. Students discuss the balance between national security and personal privacy, and the ethical considerations of zero-day disclosures and state-sponsored cyber operations.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 1,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 2,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 3,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 4,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 5,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Robotis", "test desc" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 6,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 7,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 8,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 9,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 10,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 11,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Visual Basics Fundamentals", "test desc" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 12,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 13,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 14,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 15,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 16,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 17,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 18,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 19,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 20,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 21,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 22,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 23,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 24,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 25,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 26,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 27,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 28,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 29,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 30,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 31,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 32,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 33,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 34,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 35,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 36,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 37,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 38,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 39,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 40,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 41,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 42,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 43,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 44,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 45,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 46,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 47,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 48,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 49,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 50,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 51,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 52,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 53,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 54,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 55,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 56,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 57,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 58,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 59,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 60,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 61,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 62,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 63,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Overrriding", "test desc" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 64,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 65,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 66,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 67,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 68,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 69,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 70,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 71,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 72,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 73,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 74,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 75,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 76,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 77,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 78,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 79,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 80,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 81,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 82,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 83,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 84,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 85,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 86,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 87,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 88,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 89,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 90,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 91,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 92,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 93,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 94,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 95,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 96,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 97,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 98,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 99,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 100,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 101,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 102,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 103,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 104,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 105,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 106,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 107,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Priority  Queues", "test desc" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 108,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 109,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 110,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 111,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 112,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 113,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 114,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 115,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 116,
                columns: new[] { "Name", "TopicDesc" },
                values: new object[] { "Demonstrate the Association  between Abstract Data Types and Basic Java Constructs", "test desc" });

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 117,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 118,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 119,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 120,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 121,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 122,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 123,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 124,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 125,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 126,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 127,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 128,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 129,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 130,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 131,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 132,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 133,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 134,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 135,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 136,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 137,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 138,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 139,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 140,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 141,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 142,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 143,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 144,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 145,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 146,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 147,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 148,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 149,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 150,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 151,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 152,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 153,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 154,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 155,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 156,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 157,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 158,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 159,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 160,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 161,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 162,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 163,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 164,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 165,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 166,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 167,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 168,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 169,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 170,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 171,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 172,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 173,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 174,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 175,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 176,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 177,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 178,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 179,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 180,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 181,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 182,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 183,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 184,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 185,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 186,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 187,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 188,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 189,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 190,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 191,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 192,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 193,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 194,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 195,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 196,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 197,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 198,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 199,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 200,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 201,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 202,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 203,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 204,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 205,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 206,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 207,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 208,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 209,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 210,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 211,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 212,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 213,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 214,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 215,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 216,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 217,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 218,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 219,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 220,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 221,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 222,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 223,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 224,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 225,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 226,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 227,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 228,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 229,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 230,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 231,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 232,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 233,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 234,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 235,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 236,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 237,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 238,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 239,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 240,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 241,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 242,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 243,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 244,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 245,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 246,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 247,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 248,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 249,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 250,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 251,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 252,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 253,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 254,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 255,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 256,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 257,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 258,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 259,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 260,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 261,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 262,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 263,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 264,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 265,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 266,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 267,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 268,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 269,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 270,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 271,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 272,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 273,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 274,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 275,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 276,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 277,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 278,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 279,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 280,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 281,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 282,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 283,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 284,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 285,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 286,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 287,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 288,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 289,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 290,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 291,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 292,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 293,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 294,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 295,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 296,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 297,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 298,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 299,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 300,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 301,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 302,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 303,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 304,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 305,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 306,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 307,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 308,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 309,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 310,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 311,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 312,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 313,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 314,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 315,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 316,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 317,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 318,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 319,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 320,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 321,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 322,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 323,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 324,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 325,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 326,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 327,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 328,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 329,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 330,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 331,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 332,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 333,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 334,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 335,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 336,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 337,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 338,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 339,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 340,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 341,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 342,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 343,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 344,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 345,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 346,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 347,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 348,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 349,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 350,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 351,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 352,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 353,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 354,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 355,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 356,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 357,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 358,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 359,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 360,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 361,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 362,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 363,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 364,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 365,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 366,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 367,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 368,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 369,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 370,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 371,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 372,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 373,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 374,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 375,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 376,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 377,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 378,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 379,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 380,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 381,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 382,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 383,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 384,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 386,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 387,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 388,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 389,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 390,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 391,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 392,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 393,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 394,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 395,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 396,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 397,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 398,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 399,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 400,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 401,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 402,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 403,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 404,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 405,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 406,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 407,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 408,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 409,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 410,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 411,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 412,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 413,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 414,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 415,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 416,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 417,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 418,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 419,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 420,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 421,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 422,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 423,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 424,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 425,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 426,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 427,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 428,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 429,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 430,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 431,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 432,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 433,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 434,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 435,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 436,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 437,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 438,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 439,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 440,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 441,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 442,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 443,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 444,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 445,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 446,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 447,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 448,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 449,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 450,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 451,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 452,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 453,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 454,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 455,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 456,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 457,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 458,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 459,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 460,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 461,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 462,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 463,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 464,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 465,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 466,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 467,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 468,
                column: "TopicDesc",
                value: "test desc");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "CourseId", "Name", "TopicDesc" },
                values: new object[] { 385, 465, "Signal Processing", "test desc" });
        }
    }
}
