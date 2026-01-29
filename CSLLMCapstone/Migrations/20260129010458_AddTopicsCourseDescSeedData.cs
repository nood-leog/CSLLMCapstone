using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CSLLMCapstone.Migrations
{
    /// <inheritdoc />
    public partial class AddTopicsCourseDescSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 102,
                column: "CourseDesc",
                value: "CS 102 guides students to analyze the impact of health factors through construction of a personal health index calculator and create health analysis tools with instantaneous updating. Students will also evaluate the pros and cons of technology in the health field. Course topics will vary but may include Big Tech, Video games, Telemedicine, Artificial intelligence, Robotics, 5G, Deep web, Virtual reality, Music technology, Wearables, and Ethics. The course emphasizes exploration of new methods of obtaining, analyzing, and reporting information in health-technology. Students will engage through written papers and group discussions, and create their own personal health index calculator through simple, beginning-level programming.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 105,
                column: "CourseDesc",
                value: "CS 105 guides students in developing mathematical and quantitative reasoning skills by learning the fundamentals of computer programming. Learning to program helps students develop enhanced critical thinking skills, grounded in mathematical logic and quantitative reasoning. Students gain an understanding of possible connections between technology and artistic expression. Course goals include students demonstrating knowledge of the inner workings of the digital revolution, composing the mathematical logic required to solve problems with programming code, and demonstrating mathematical and quantitative reasoning skills by identifying the programming code needed to solve problems of increasing complexity.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 107,
                column: "CourseDesc",
                value: "CS 107 focuses on the complete principles of software development, guiding students through the full lifecycle from requirement specification to deployment and maintenance. The primary goal is to foster the ability to apply both theoretical and practical knowledge to develop various software tools, packages, or libraries addressing a specific problem statement. Students will gain hands-on experience in designing, debugging, and executing programs in modern programming languages such as Java. The course uses Unreal Engine 4.24.xx.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 109,
                column: "CourseDesc",
                value: "CS 109 explores quantitative and statistical processes by implementing the programming language Python. Students will apply procedures from Python's data visualization libraries to present data in formats including, but not limited to, graphs, histograms, and bar charts. They will evaluate these mathematical forms to formulate meaningful conclusions. In addition to quantitative and statistical processes, students will learn programming skills to develop enhanced critical thinking skills, grounded in logic and reason. Course topics include Introduction to Python, Data visualization, Classes and Object Oriented Programming (OOP), Stochastic programs, probability and distributions, Sampling and confidence intervals, Understanding experimental data, Hypothesis checking, and Conditional probability and Bayesian statistics.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 110,
                column: "CourseDesc",
                value: "CS110 teaches students the basics of writing Java programs to solve problems of increasing complexity. Specific learner outcomes include implementing sequential programming, decision statements, repetition constructs (including nested loops), and arithmetic operators. Students will also implement Java primitive data type variables, file processing, methods to modularize programs, class definitions, and arrays and objects of the ArrayList class.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 111,
                column: "CourseDesc",
                value: "CS 111 provides an in-depth exploration of intermediate programming concepts in Java, building upon the foundations of Programming Fundamentals I. Students advance their skills in object-oriented programming, specifically focusing on inheritance, polymorphism, and abstract classes to create scalable and reusable code. The course also reinforces core logic while introducing complex topics like Advanced File I/O, including object serialization and random access files, alongside a thorough introduction to Recursion. Beyond command-line applications, students are expected to design and implement Graphical User Interfaces (GUIs) using Event Listeners and Layout Managers. This comprehensive approach ensures students understand how to transition from basic logic to building robust, interactive software systems equipped with professional error-handling and debugging techniques.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 112,
                column: "CourseDesc",
                value: "CS112 focuses on the foundations of data science and its applications, including how the data science process can be used to address real-life problems. Students will identify key characteristics of Python programming, including syntax, semantics, debugging, and data science packages. The course aims to resolve compilation warnings and error messages in Python and demonstrate full understanding of the Python programming paradigms in respect to the data science paradigm.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 301,
                column: "CourseDesc",
                value: "CS 301 explores data structures, algorithms for manipulating them, and the practical problems of implementing those structures in real programming languages and environments. Attention is paid to the analysis of algorithms to characterize their worst and average case requirements for running time and memory. The course should expand the students' toolbox of basic techniques for manipulating data at both the conceptual and the concrete level. Topics will proceed through classic data structures and Java-based containers, exploring the use and implementation of each. Motivating problems will be drawn from a variety of application areas.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 302,
                column: "CourseDesc",
                value: "CS 302 continues the exploration of data structures, algorithms for manipulating them, and implementing those structures in real programming languages and environments. This course will focus on the analysis of algorithms to characterize worst and average case requirements for running time and memory. Students will be able to apply basic complexity measures and demonstrate the correct use and application of various data structures, including trees, hashing, and graphs. The primary goal is to expand the student's toolbox of basic techniques for manipulating data at both the conceptual and concrete levels.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 311,
                column: "CourseDesc",
                value: "CS 311 is an introduction to computer architecture focusing on assembly language programming on the x86-64 bit architecture. The course uses the yasm assembly compiler and the ebe interface. Students will learn to create and modify programs of significant size using 64-bit Assembly language. Course topics include numbers type conversions, computer memory architecture, registers in 32/64-bit modes, arithmetic, bit operations, branching, looping, and functions in Assembly. The primary goal is to gain hands-on experience in Assembly language programming.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 312,
                column: "CourseDesc",
                value: "CS 312 focuses on distinguishing between computer architecture and computer organization, and using Boolean algebra to solve basic logic problems. Students will describe the operation of CPU, memory, bus, and I/O, and compare different instruction sets for processors. The course will cover topics such as Digital Logic, Cache Memory, and Instruction Sets. The primary goal is for students to comprehend different gate and logic-based structures and analyze various computer architectures. Students will gain hands-on experience using software like MultiMedia Logic and Java.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 325,
                column: "CourseDesc",
                value: "CS 325 is a writing-intensive, upper-division course that prepares students for professional communication within the computer science field. The curriculum focuses on mastering technical writing, editing, and ethical practices, with a heavy emphasis on APA documentation. Students engage in a workshop-oriented environment, applying their skills through hands-on assignments such as technical summaries, research proposals, annotated bibliographies, and professional presentations. By utilizing software tools like LaTeX and Microsoft Office, students learn to produce high-quality documentation that meets industry standards. The course requires significant effort outside of class to refine professional-level writing and mechanical proficiency.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 351,
                column: "CourseDesc",
                value: "CS 351 provides an in-depth exploration of server-side technologies essential for modern web software development. Students advance their skills in programming languages and database access, specifically focusing on designing and creating dynamic web applications using PHP and SQL. The course also reinforces client-side mastery of XHTML, CSS, and JavaScript, while introducing complex topics like e-commerce and system testing. Beyond technical implementation, students are expected to articulate ethical positions on contemporary web issues and deliver professional oral presentations on their designs. This comprehensive approach ensures students understand both the functional and societal impacts of web technologies.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 361,
                column: "CourseDesc",
                value: "CS 361 introduces the fundamental principles of programming language design and software construction, primarily using the C programming language. The course covers essential topics including data types, operators, expressions, functions, and scope. Students delve into complex concepts such as pointers, arrays, strings, dynamic memory management, and structures. By following a structured approach to branching, iteration, and input/output, learners gain a deep understanding of how languages are implemented and utilized. Through these technical foundations, the course aims to develop a student's ability to design efficient software and understand the underlying mechanics of various programming paradigms.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 362,
                column: "CourseDesc",
                value: "CS 362 explores the fundamental concepts of programming languages by examining design issues, syntax description methods, and semantic models. Students critically compare design alternatives across various common languages and study implementation methods integrated throughout the class. Key topics include abstract data types, parallel processing, object-oriented programming, exception handling, and functional and logic programming. Upon completion, students will be able to apply formal methods of syntax, such as attribute grammars, and understand static and dynamic semantics. The course ultimately empowers students to compare computer languages effectively and demonstrate advanced knowledge in naming and language constructs.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 367,
                column: "CourseDesc",
                value: "CS 367 provides a comprehensive introduction to the fundamental principles of software engineering, focusing on the systematic processes required to build high-quality software systems. Students explore the Software Development Life Cycle (SDLC), covering essential phases such as requirements elicitation, system analysis, and architectural design. The curriculum emphasizes Object-Oriented Analysis and Design (OOAD) using UML for modeling and documentation. Additionally, the course addresses practical industry concerns, including project management, software testing strategies, and the ethical implications of technology. Through collaborative projects and technical writing, students learn to translate complex user needs into robust, maintainable software solutions.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 370,
                column: "CourseDesc",
                value: "CS 370 provides a comprehensive introduction to the Linux operating system, focusing on its architecture, command-line interface, and administrative capabilities. Students explore the fundamental philosophy of Linux, learning to navigate the file system, manage permissions, and utilize shell scripting for task automation. The course curriculum covers essential topics such as process management, software installation, and system configuration, emphasizing practical, hands-on experience. Students also delve into networking basics and security protocols within the Linux environment. By the end of the term, learners will have developed the technical proficiency required to manage Linux-based systems effectively in both personal and professional computing contexts.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 380,
                column: "CourseDesc",
                value: "CS 380 introduces the fundamental principles and professional practices of software engineering, with a core focus on object-oriented analysis and design. Students explore essential methodologies, including the use of design patterns (specifically Java patterns) and the implementation of robust testing strategies. The curriculum covers the entire Software Development Lifecycle, from project planning and requirements gathering using UML diagrams to version control and final execution. Beyond technical skills, the course emphasizes human-centric elements such as customer interaction, team organization, and conflict resolution. Through collaborative projects and progress presentations, students gain practical experience in managing large-scale resources and delivering quality software solutions.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 420,
                column: "CourseDesc",
                value: "CS 420 provides an in-depth exploration of the logical aspects of database processing and the concepts of organizing data into integrated databases. Students examine various structural approaches, including hierarchical, network, and relational models. The curriculum focuses on translating complex user requirements into valid database designs using Entity/Relationship (E/R) modeling and relational algebra. Practical skills are emphasized through the mastery of Structured Query Language (SQL) and the application of normalization principles via functional dependencies. By utilizing industry-standard tools like MySQL Workbench, students learn to identify and implement high-quality relational database designs. The course ensures that learners can effectively manage data integrity and optimize database organization for modern software applications.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 427,
                column: "CourseDesc",
                value: "CS 427 provides a rigorous study of algorithm design, algorithm complexity analysis, and problem complexity analysis. The course explores fundamental problem-solving strategies, including divide-and-conquer, dynamic programming, greedy algorithms, backtracking, and branch-and-bound techniques. Students learn to evaluate the efficiency of algorithms using asymptotic notation, focusing on both time and space complexity for iterative and recursive processes. By applying these strategies to traditional and non-traditional computing domains, students develop high-level critical thinking and technical skills. The curriculum emphasizes mastering specific strategies to solve complex mathematical and computational problems efficiently.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 428,
                column: "CourseDesc",
                value: "CS 428 offers a comprehensive introduction to the field of graph algorithms, focusing on the identification, analysis, and practical solution of algorithmic graph problems. The curriculum spans fundamental concepts, including graph terminology and implementation variants like directed, undirected, and weighted graphs. Students master essential search techniques such as DFS, BFS, and Maximum Cardinality Search, while exploring efficiently solvable problems like shortest paths (A* and Floyd-Warshall), Max-Flow, and Min-Cut. Additionally, the course delves into advanced topics such as graph coloring, isomorphism, and planarity. Through lab assignments and quizzes, students develop the skills necessary to apply these complex mathematical structures to real-world computing challenges.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 430,
                column: "CourseDesc",
                value: "CS 430 provides a comprehensive overview of computer security, spanning from fundamental principles to contemporary security trends and the evolving threat environment. The curriculum covers critical areas such as general security principles, operational and organizational controls, and the vital human element in cybersecurity. Students delve into technical topics including cryptography, physical security concepts, and network fundamentals. Additionally, the course explores IT infrastructure security practices, authentication mechanisms, remote access, and wireless security. A significant focus is placed on understanding and implementing methods to counter cyber-attacks in modern computer systems. By combining theoretical knowledge with practical defense strategies, students develop the skills necessary to protect digital assets and maintain secure computing environments.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 440,
                column: "CourseDesc",
                value: "CS 440 introduces the fundamental concepts, algorithms, and challenges within the field of computer graphics, along with a survey of modern graphics software and hardware systems. Students develop the technical ability to write graphics programs using OpenGL, mastering both 2-D and 3-D techniques. The curriculum emphasizes the mathematical foundations of graphics, including vector manipulation, dot and cross products, and matrix techniques for rotation, scaling, and translation. Additionally, students explore advanced topics such as vector clipping, scientific visualization, and image processing. Through hands-on programming assignments involving rosettes, arcs, and clipping algorithms, learners gain practical experience in rendering complex visual data and managing aspect ratios in dynamic windows.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 445,
                column: "CourseDesc",
                value: "CS 445 explores the principles of Data Visualization, focusing on transforming complex data into insightful visual representations. Students learn to utilize tools like Jupyter Notebooks, Matplotlib, and Seaborn to create effective marks and channels for data abstraction. The curriculum covers task abstraction, spatial fields, and the arrangement of networks and trees. Key topics include color theory, 3D graph practice, and advanced techniques such as Principal Component Analysis (PCA) and map visualization. Through lab assignments and a multi-phase final project, students master rules of thumb for design and gain practical experience in visual knowledge discovery and machine learning integration.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 446,
                column: "CourseDesc",
                value: "CS 446 focuses on the fundamental principles of Human-Computer Interaction (HCI) and the design of effective user interfaces. Using Don Norman's The Design of Everyday Things as a foundation, students explore psychological concepts like affordances, signifiers, and mental models to understand how users interact with technology. The curriculum follows a practical, lab-based approach covering the entire design lifecycle, including requirements gathering, paper prototyping, and computer-based implementation using Visual C#. Students master critical topics such as usability testing, accessibility, information visualization, and graphic design elements like typography and color theory. Through a multi-phase project, learners gain hands-on experience in building and evaluating interfaces that are intuitive, safe, and efficient.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 450,
                column: "CourseDesc",
                value: "CS 450 provides a comprehensive examination of the technical foundations of networking and data communication. The course focuses on critical concepts such as device and network protocols, network configurations, and infrastructure topologies. Students analyze the nature of protocol layering and identify the primary standards bodies that govern global networking. The curriculum also delves into advanced topics including encryption, data compression, and network security. Practical objectives include identifying LAN architectures and evaluating the messaging mechanisms of various network operating systems. By the end of the course, students will be equipped to analyze the functionality of modern computer networks and understand the fundamentals of wide area versus local area communications.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 452,
                column: "CourseDesc",
                value: "CS 452 focuses on ethical offensive security techniques. It covers exploiting vulnerabilities like SQL injection, input validation flaws, and scripting attacks. The curriculum is structured to cover the full process, including reconnaissance, vulnerability scanning, and penetration testing. Students will use DevOps security tools to simulate and analyze real-world attacks. Key topics include Enumeration, Vulnerability Analysis, Exploitation, Privilege Escalation, and Post-Exploitation. Further content covers Web Interception, Malware Analysis, Wireless, Cloud & IoT Attacks, AI-powered ethical hacking, and professional reporting.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 456,
                column: "CourseDesc",
                value: "CS456 studies algorithms and computational paradigms to find patterns, regularities, and perform prediction in databases. It is a key element of Knowledge Discovery, covering the full process from data selection, cleaning, and coding to using statistical and machine learning techniques, and visualization. The course emphasizes Machine Learning methods as real knowledge discovery tools. Important related technologies, such as data warehousing, are also discussed. Students will gain proficiency in techniques like classification, clustering, association rule mining, and regression, and apply them to real-world problems using recent Data Mining software. The main goal is to extract useful knowledge from raw data.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 457,
                column: "CourseDesc",
                value: "CS 457 introduces intelligent systems from a machine learning perspective, focusing on the fundamentals of Computational Intelligence and Machine Learning (CI & ML) models. Typical topics include neural networks, supervised and unsupervised learning, clustering, support vector machines, evolutionary learning, deep learning, and convolutional neural networks. Upon completion, students will understand core CI & ML models, implement algorithms, and apply techniques to solve classification, regression, prediction, and optimization problems. Practical application is emphasized through three group projects and an individual final project. Students are encouraged to use software tools like Python, Anaconda, and Weka for implementation.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 460,
                column: "CourseDesc",
                value: "CS 460 provides a comprehensive introduction to the principles and practices of database systems, focusing on both traditional and modern data management techniques. The curriculum covers fundamental concepts of relational database models, including relational algebra, SQL, and database design using entity-relationship and functional dependency modeling. Students will also explore advanced topics such as NoSQL databases, transaction management, concurrency control, and data warehousing. A major component of the course is hands-on experience in designing, implementing, and querying a database system. The course objective is to enable students to effectively design and manage robust, scalable, and secure data storage solutions for various applications.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 465,
                column: "CourseDesc",
                value: "CS 465 covers different topics in scientific computing, including numerical computation, mathematical modeling, statistical modeling, optimization, and machine learning. Taught asynchronously, the curriculum is designed to help students formulate techniques required to implement and use mathematical algorithms to a variety of complex computational problems. Key content areas include an introduction to computing with Python, symbolic computing, plotting and visualization, equation solving, and various advanced topics like sparse matrices, data processing, Bayesian statistics, and signal processing. Students will demonstrate their knowledge by applying coding skills to develop solutions using scientific computing libraries and tools. Assessment consists of five lab exercises with both written and coding parts, and a final project is assigned only to CS 565 students.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 466,
                column: "CourseDesc",
                value: "CS 466 is an introduction to virtual reality application development and human-computer interaction research. The course covers essential topics including 3D programming, virtual reality application domains, 3D interaction designs, and the development of human-computer interaction research papers. Students will also explore experimental study designs. This is a hybrid class with asynchronous online assignments and real-time meetings for demonstrations, discussions, and projects. The curriculum uses the Unity 3D game engine for programming and requires a smartphone and a Google Cardboard-like VR Viewer. The course integrates a group term project, worth 40% of the grade, where student teams develop a VR-related human-computer interaction research paper.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 467,
                column: "CourseDesc",
                value: "CS 467 explores the interface between statistics and computer science, encompassing computational and graphical approaches to solving statistical problems. Students will learn to manipulate and analyze data, design simulated experiments, and use resampling methods. The primary focus is on the in-depth understanding and use of the R Language, the predominate software platform for statistical analysis. The curriculum covers key topics like correlation, linear regression, and logistic regression. The course includes four research seminars and two complex programming projects involving background research, coding, and analysis of results.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 470,
                column: "CourseDesc",
                value: "CS 470 provides a fundamental understanding of the structure and function of contemporary operating systems, with a primary focus on UNIX-based systems, including Linux and Windows. It begins with an architectural overview, followed by an in-depth exploration of major components like processes, threads, memory management, and file I/O. Students will assess and critically analyze various CPU scheduling algorithms, recognizing their advantages and limitations. Through practical assessments, students will demonstrate the ability to discern and articulate different strategies within the operating system framework. The goal is to prepare students for advanced academic study or professional pursuits in computer science.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 471,
                column: "CourseDesc",
                value: "CS 471 is an intensive study of operating systems principles and implementation. Key topics include process and thread management, CPU scheduling algorithms, synchronization, deadlock prevention, and concurrent programming. A major focus is on memory management, covering virtual memory, paging, and segmentation techniques. The curriculum also delves into file system structure, I/O systems, and the fundamentals of system security. Students will gain practical experience in system-level programming and apply theoretical concepts to understand the design and trade-offs of modern operating systems. The core objective is to equip students with the knowledge to analyze, design, and implement operating system components.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 473,
                column: "CourseDesc",
                value: "CS 473 provides a comprehensive study of parallel computing, focusing on the design and implementation of parallel algorithms. Key topics include Parallel Algorithm Design, Shared-Memory Programming with OpenMP, CUDA, Message-Passing Programming (MPI), and Performance Analysis. Students will engage with advanced concepts such as the Sieve of Eratosthenes, Floyd's Algorithm, Document Classification, and Combinatorial Search. The course includes a rigorous laboratory schedule with multiple projects, challenging students to implement concepts in OpenMP, CUDA, and MPI. The course material includes a major technical report and an online book by Ian Foster.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 480,
                column: "CourseDesc",
                value: "CS 480 provides advanced principles and practices for the complete software engineering lifecycle. The curriculum covers project management, requirements gathering and specification, design, coding, testing, maintenance, and documentation. Students will study the software product lifecycle, from problem definition and client interaction to deployment. A key focus is on acquiring and integrating concepts like software project management and learning how to prepare essential documentation, such as a Software Requirements Specification. The course emphasizes teamwork and culminates in students working in teams to develop a large software project.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 481,
                column: "CourseDesc",
                value: "CS 481 focuses on the complete principles of software development, guiding students through the full lifecycle from requirement specification to deployment and maintenance. The primary goal is to foster the ability to apply both theoretical and practical knowledge to develop various software tools, packages, or libraries addressing a specific problem statement. The course content is structured around weekly discussions, five major assignments, and two required presentations (midterm and final). Students will gain hands-on experience in designing, debugging, and executing programs in modern programming languages such as Python, Java, JavaScript, and C++. The project culminates in an oral defense of the developed software.");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 489,
                column: "CourseDesc",
                value: "CS489 is an introduction to research in computer science through the investigation of ethical and historical topics in the field. It also includes end-of-major assessment activities. Topics may include AI Ethics, Professional Responsibility, Computer Crime, and Internet Security. Students will research current topics, prepare written reports on ethical or historical topics, and present their research results with critical analysis to the class. A Major Field Test (MFT) is also required for the course.");

            migrationBuilder.InsertData(
                table: "Topics",
                columns: new[] { "TopicId", "CourseId", "Name", "TopicDesc" },
                values: new object[,]
                {
                    { 11, 105, "Visual Basics Fundamentals", "test desc" },
                    { 12, 105, "Mathematical/Logical Basis of Computing", "test desc" },
                    { 13, 105, "Quantitative Reasoning", "test desc" },
                    { 14, 105, "Social/Political/Ethical Implications of Technological Advancement", "test desc" },
                    { 15, 105, "Data Association Implementing Parallel Mapping", "test desc" },
                    { 16, 105, "Computational Thinking", "test desc" },
                    { 17, 105, "Algorithm Sequencing", "test desc" },
                    { 18, 105, "Integrated Development Environment (IDE) Proficiency", "test desc" },
                    { 19, 107, "Unreal Engine Fundamentals and Software Development", "test desc" },
                    { 20, 107, "Elements of a Game", "test desc" },
                    { 21, 107, "Designing a Game", "test desc" },
                    { 22, 107, "Brainstorming", "test desc" },
                    { 23, 107, "Narrative and Backstory", "test desc" },
                    { 24, 107, "Scenario", "test desc" },
                    { 25, 107, "Storyboard and Script", "test desc" },
                    { 26, 107, "Usability and Accessibility", "test desc" },
                    { 27, 107, "Ethical/Social/Legal Issues in Gaming", "test desc" },
                    { 28, 107, "Game-based Learning and Gamification", "test desc" },
                    { 29, 107, "Gaming Science", "test desc" },
                    { 30, 107, "History in Gaming", "test desc" },
                    { 31, 107, "Careers in Gaming", "test desc" },
                    { 32, 107, "Future of Gaming", "test desc" },
                    { 33, 107, "Rise of Gaming Subcultures", "test desc" },
                    { 34, 109, "Python Fundamentals", "test desc" },
                    { 35, 109, "Data Visualization", "test desc" },
                    { 36, 109, "Classes and OOP", "test desc" },
                    { 37, 109, "Stochastic Programs", "test desc" },
                    { 38, 109, "Probability and Distributions", "test desc" },
                    { 39, 109, "Sampling and Confidence Intervals", "test desc" },
                    { 40, 109, "Understanding Experimental Data", "test desc" },
                    { 41, 109, "Hypothesis Checking", "test desc" },
                    { 42, 109, "Conditional Probability and Bayesian Statistics", "test desc" },
                    { 43, 110, "Java Fundamentals", "test desc" },
                    { 44, 110, "Decision Structures", "test desc" },
                    { 45, 110, "Careers in Gaming", "test desc" },
                    { 46, 110, "Repetition", "test desc" },
                    { 47, 110, "Methods", "test desc" },
                    { 48, 110, "Classes", "test desc" },
                    { 49, 110, "Object Oriented Programming", "test desc" },
                    { 50, 110, "Arrays and ArrayLists", "test desc" },
                    { 51, 111, "Static Fields and Methods", "test desc" },
                    { 52, 111, "Returning Objects from Methods", "test desc" },
                    { 53, 111, "toString Method", "test desc" },
                    { 54, 111, "Comparing Objects", "test desc" },
                    { 55, 111, "Aggregation", "test desc" },
                    { 56, 111, "Copy Constructor", "test desc" },
                    { 57, 111, "Null Reference", "test desc" },
                    { 58, 111, "Enums", "test desc" },
                    { 59, 111, "StringBuilder", "test desc" },
                    { 60, 111, "Tokenizing", "test desc" },
                    { 61, 111, "Inheritance", "test desc" },
                    { 62, 111, "Superclasses", "test desc" },
                    { 63, 111, "Overrriding", "test desc" },
                    { 64, 111, "Protected Members", "test desc" },
                    { 65, 111, "Chains of Inheritance", "test desc" },
                    { 66, 111, "Polymorphism", "test desc" },
                    { 67, 111, "Abstract Classes", "test desc" },
                    { 68, 111, "Exceptions", "test desc" },
                    { 69, 111, "Error Handling", "test desc" },
                    { 70, 111, "Advanced File I/O", "test desc" },
                    { 71, 111, "Binary Files", "test desc" },
                    { 72, 111, "Random Access Files", "test desc" },
                    { 73, 111, "Object Serialization", "test desc" },
                    { 74, 111, "Binary Search", "test desc" },
                    { 75, 111, "Recursion", "test desc" },
                    { 76, 111, "GUI Applications", "test desc" },
                    { 77, 111, "Action Listeners", "test desc" },
                    { 78, 112, "Python Fundamentals", "test desc" },
                    { 79, 112, "Troubleshooting and Debugging in Python", "test desc" },
                    { 80, 112, "Identifying Data Science Packages in Python", "test desc" },
                    { 81, 112, "Foundations of Data Science", "test desc" },
                    { 82, 112, "Real-World Data Science Applications", "test desc" },
                    { 83, 112, "Python Programming Paradigms for Data Science", "test desc" },
                    { 84, 301, "Abstract Data Type (ADT)", "test desc" },
                    { 85, 301, "Recursion", "test desc" },
                    { 86, 301, "Asymptotic Algorithm Analysis", "test desc" },
                    { 87, 301, "Big O Notation", "test desc" },
                    { 88, 301, "Lists", "test desc" },
                    { 89, 301, "Stack", "test desc" },
                    { 90, 301, "Queue", "test desc" },
                    { 91, 301, "Linked List", "test desc" },
                    { 92, 301, "Tree", "test desc" },
                    { 93, 301, "Tree Traversal", "test desc" },
                    { 94, 301, "Binary Search Tree (BST)", "test desc" },
                    { 95, 301, "BST as Dictionary", "test desc" },
                    { 96, 301, "Insertion Sort", "test desc" },
                    { 97, 301, "Java Collection Framework", "test desc" },
                    { 98, 301, "Unit Testing", "test desc" },
                    { 99, 301, "Backtracking", "test desc" },
                    { 100, 302, "Exploration of Data Structures like Trees", "test desc" },
                    { 101, 302, "Binary Trees", "test desc" },
                    { 102, 302, "Search Trees", "test desc" },
                    { 103, 302, "Balanced Trees", "test desc" },
                    { 104, 302, "2-3 Trees", "test desc" },
                    { 105, 302, "B-trees", "test desc" },
                    { 106, 302, "Heaps", "test desc" },
                    { 107, 302, "Priority  Queues", "test desc" },
                    { 108, 302, "Hashing", "test desc" },
                    { 109, 302, "Maps", "test desc" },
                    { 110, 302, "Sets", "test desc" },
                    { 111, 302, "Matrices", "test desc" },
                    { 112, 302, "Graphs", "test desc" },
                    { 113, 302, "Basic Complexity Measures to Basic Algorithms and how they were Obtained", "test desc" },
                    { 114, 302, "Exploration of Data Structures like Trees", "test desc" },
                    { 115, 302, "Basic Understanding of an Abstract Data Types", "test desc" },
                    { 116, 302, "Demonstrate the Association  between Abstract Data Types and Basic Java Constructs", "test desc" },
                    { 117, 311, "Numbers Type Conversions (Different Bases)", "test desc" },
                    { 118, 311, "Computer Memory Architecture", "test desc" },
                    { 119, 311, "Memory Mapping in 64-bit Mode", "test desc" },
                    { 120, 311, "Registers in 32/64-bit Modes", "test desc" },
                    { 121, 311, "Arithmetic in Assembly", "test desc" },
                    { 122, 311, "Bit Operations", "test desc" },
                    { 123, 311, "Branching and Loop in Assembly", "test desc" },
                    { 124, 311, "Functions in Assembly", "test desc" },
                    { 125, 312, "Basic Concepts and Computer Evolution", "test desc" },
                    { 126, 312, "Digital Logic", "test desc" },
                    { 127, 312, "Computer Evolution/ Performance", "test desc" },
                    { 128, 312, "Computer Interconnection", "test desc" },
                    { 129, 312, "Cache Memory", "test desc" },
                    { 130, 312, "Internal Memory", "test desc" },
                    { 131, 312, "Input/Output", "test desc" },
                    { 132, 312, "Instruction Sets-1", "test desc" },
                    { 133, 312, "Instruction Sets-2", "test desc" },
                    { 134, 312, "Processor Structure and Function", "test desc" },
                    { 135, 312, "Reduced Instruction Set Computers (RISC)", "test desc" },
                    { 136, 312, "Instruction-Level Parallelism and SuperScalar Processors", "test desc" },
                    { 137, 312, "General-Purpose Graphic Processing Units (GPGPU) Computing", "test desc" },
                    { 138, 325, "Writing, Editing, and Ethical Practices in the Field of Computer Science", "test desc" },
                    { 139, 325, "Technical Writing for Summaries", "test desc" },
                    { 140, 325, "Visualization Tables, Charts, and Graphs", "test desc" },
                    { 141, 325, "Cover Letter", "test desc" },
                    { 142, 325, "Reviewer's Report", "test desc" },
                    { 143, 325, "Procedures", "test desc" },
                    { 144, 325, "Research Proposal with Annotated Biblography", "test desc" },
                    { 145, 325, "Survey of Literature", "test desc" },
                    { 146, 325, "PowerPoint", "test desc" },
                    { 147, 325, "Mechanics Exam", "test desc" },
                    { 148, 351, "Web Development Fundamentals", "test desc" },
                    { 149, 351, "HTML and CSS Fundamentals", "test desc" },
                    { 150, 351, "JavaScript Fundamentals", "test desc" },
                    { 151, 351, "jQuery Fundamentals", "test desc" },
                    { 152, 351, "PHP Fundamentals", "test desc" },
                    { 153, 351, "Designing and Creating Web Application", "test desc" },
                    { 154, 351, "Analyzing Contemporary Issues Related to Web", "test desc" },
                    { 155, 361, "Types, Operator and Expressions", "test desc" },
                    { 156, 361, "Branching and Operator", "test desc" },
                    { 157, 361, "Functions, Scope and Extent", "test desc" },
                    { 158, 361, "Pointers, Array and Strings", "test desc" },
                    { 159, 361, "Dynamic Memory", "test desc" },
                    { 160, 361, "Structures and Union", "test desc" },
                    { 161, 361, "Input and Output", "test desc" },
                    { 162, 361, "Difference from C in C++", "test desc" },
                    { 163, 361, "Classes and Objects", "test desc" },
                    { 164, 362, "Meta language (ML) Basics", "test desc" },
                    { 165, 362, "Types", "test desc" },
                    { 166, 362, "Polymorphism", "test desc" },
                    { 167, 362, "Scope", "test desc" },
                    { 168, 362, "Parallel Algorithm Design", "test desc" },
                    { 169, 362, "Concurrent Programming", "test desc" },
                    { 170, 362, "Eratosthenes", "test desc" },
                    { 171, 362, "Floyd's Algorithm", "test desc" },
                    { 172, 367, "Memory Allocation", "test desc" },
                    { 173, 367, "Data Types", "test desc" },
                    { 174, 367, "Arithmetic Operators", "test desc" },
                    { 175, 367, "Sequential Programming", "test desc" },
                    { 176, 367, "Validation of User Input", "test desc" },
                    { 177, 367, "Relational Operators", "test desc" },
                    { 178, 367, "Boolean Expressions", "test desc" },
                    { 179, 367, "Loop Termination Conditions", "test desc" },
                    { 180, 367, "Modularize Code by Implementing Functions and Procedures", "test desc" },
                    { 181, 367, "File Processing to Maintain a Permanent Record of Data Generated", "test desc" },
                    { 182, 367, "Single and Two Dimensional Arrays", "test desc" },
                    { 183, 367, "Object-oriented Programming", "test desc" },
                    { 184, 370, "Installing Linux Distributions", "test desc" },
                    { 185, 370, "Command Line", "test desc" },
                    { 186, 370, "Shell Expansion", "test desc" },
                    { 187, 370, "Pipes and Commands", "test desc" },
                    { 188, 370, "Scripting", "test desc" },
                    { 189, 370, "Local User Management", "test desc" },
                    { 190, 370, "File Security", "test desc" },
                    { 191, 380, "Software Development Lifecycles", "test desc" },
                    { 192, 380, "Project Planning", "test desc" },
                    { 193, 380, "Scope", "test desc" },
                    { 194, 380, "Requirements", "test desc" },
                    { 195, 380, "Use Cases", "test desc" },
                    { 196, 380, "Sequence Diagrams", "test desc" },
                    { 197, 380, "Design Patterns", "test desc" },
                    { 198, 380, "Activity Diagrams", "test desc" },
                    { 199, 380, "Class Diagrams", "test desc" },
                    { 200, 380, "Test Cases", "test desc" },
                    { 201, 420, "Databases and Database Users", "test desc" },
                    { 202, 420, "Database System Concepts and Architecture", "test desc" },
                    { 203, 420, "The Relational Data Model", "test desc" },
                    { 204, 420, "Relational Database Constraints", "test desc" },
                    { 205, 420, "Basics of Functional Dependencies", "test desc" },
                    { 206, 420, "Normalization for Relational Databases", "test desc" },
                    { 207, 420, "Data Modeling Using the Entity Relationship (ER) Model", "test desc" },
                    { 208, 420, "Relational Algebra", "test desc" },
                    { 209, 420, "Relational Calculus", "test desc" },
                    { 210, 420, "SQL", "test desc" },
                    { 211, 427, "Algorithm Design", "test desc" },
                    { 212, 427, "Algorithm Complexity Analysis", "test desc" },
                    { 213, 427, "Problem Complexity Analysis", "test desc" },
                    { 214, 427, "Divide-and-Conquer", "test desc" },
                    { 215, 427, "Dynamic Programming", "test desc" },
                    { 216, 427, "Greedy Algorithms", "test desc" },
                    { 217, 427, "Backtracking", "test desc" },
                    { 218, 427, "Branch-and-Bound", "test desc" },
                    { 219, 427, "NP-completeness", "test desc" },
                    { 220, 427, "Approximation Algorithms", "test desc" },
                    { 221, 427, "Lower-Bound Limits", "test desc" },
                    { 222, 428, "Implementation of Graph Algorithms", "test desc" },
                    { 223, 428, "Undirected Graph", "test desc" },
                    { 224, 428, "Directed Graph", "test desc" },
                    { 225, 428, "Directed Acyclic Graphs (DAGs)", "test desc" },
                    { 226, 428, "Tree", "test desc" },
                    { 227, 428, "Terminology", "test desc" },
                    { 228, 428, "Euler-Cycle", "test desc" },
                    { 229, 428, "Shortest Path", "test desc" },
                    { 230, 428, "Max-Flow", "test desc" },
                    { 231, 428, "Min-Cut", "test desc" },
                    { 232, 428, "Bipartite Matching", "test desc" },
                    { 233, 428, "Planarity", "test desc" },
                    { 234, 428, "Graph Search", "test desc" },
                    { 235, 428, "Bridge", "test desc" },
                    { 236, 428, "Articulation Point", "test desc" },
                    { 237, 428, "Connected Components", "test desc" },
                    { 238, 428, "Layering Partition", "test desc" },
                    { 239, 428, "Graph Drawing", "test desc" },
                    { 240, 428, "Graph Isomorphism", "test desc" },
                    { 241, 428, "Largest Common Subgraph", "test desc" },
                    { 242, 428, "Graph Edit Distance", "test desc" },
                    { 243, 428, "Colouring", "test desc" },
                    { 244, 428, "Packing and Covering", "test desc" },
                    { 245, 428, "Exploring Current Research Topics", "test desc" },
                    { 246, 430, "Cybersecurity Introduction", "test desc" },
                    { 247, 430, "Security Trends", "test desc" },
                    { 248, 430, "General Security Concepts", "test desc" },
                    { 249, 430, "Operational and Organizational Security", "test desc" },
                    { 250, 430, "Role of People in Security", "test desc" },
                    { 251, 430, "Cryptography", "test desc" },
                    { 252, 430, "Network Fundamentals", "test desc" },
                    { 253, 430, "Infrastructure Security", "test desc" },
                    { 254, 430, "Authentication and Remote Access", "test desc" },
                    { 255, 430, "Wireless Security", "test desc" },
                    { 256, 430, "Physical Security", "test desc" },
                    { 257, 440, "Fundamentals of Computer Graphics using OpenGL", "test desc" },
                    { 258, 440, "Drawing Figures", "test desc" },
                    { 259, 440, "Drawing Tools", "test desc" },
                    { 260, 440, "Vector Tools", "test desc" },
                    { 261, 440, "Transformations of Objects", "test desc" },
                    { 262, 440, "Fractals", "test desc" },
                    { 263, 440, "Tools for Faster Display", "test desc" },
                    { 264, 445, "Jupyter Notebook", "test desc" },
                    { 265, 445, "Data Abstraction", "test desc" },
                    { 266, 445, "Data Representation", "test desc" },
                    { 267, 445, "Effective Design of Visualization", "test desc" },
                    { 268, 445, "Static Visualization", "test desc" },
                    { 269, 445, "Interactive Visualization", "test desc" },
                    { 270, 445, "Multi-Dimensional Displays", "test desc" },
                    { 271, 445, "Marks and Channels", "test desc" },
                    { 272, 445, "Seaborn", "test desc" },
                    { 273, 445, "Rules of Thumb", "test desc" },
                    { 274, 445, "Colors", "test desc" },
                    { 275, 445, "3D Graphics", "test desc" },
                    { 276, 445, "Spatial Fields", "test desc" },
                    { 277, 445, "Map Visualization", "test desc" },
                    { 278, 445, "Arrange Network", "test desc" },
                    { 279, 445, "Trees", "test desc" },
                    { 280, 445, "Principal Component Analysis (PCA) using Python", "test desc" },
                    { 281, 446, "History of User Interface (UI)", "test desc" },
                    { 282, 446, "Usability, Learnability, Efficiency", "test desc" },
                    { 283, 446, "User-Centered Design", "test desc" },
                    { 284, 446, "Safety, Errors and User Control", "test desc" },
                    { 285, 446, "Prototyping", "test desc" },
                    { 286, 446, "Usability Testing", "test desc" },
                    { 287, 446, "UI Software Architecture", "test desc" },
                    { 288, 446, "Output", "test desc" },
                    { 289, 446, "Input", "test desc" },
                    { 290, 446, "Graphics Design", "test desc" },
                    { 291, 446, "Layout, Color, Typography", "test desc" },
                    { 292, 446, "Heuristic Evaluation", "test desc" },
                    { 293, 446, "Accessibility", "test desc" },
                    { 294, 446, "Internationalization", "test desc" },
                    { 295, 450, "Networking Foundation", "test desc" },
                    { 296, 450, "Direct Links", "test desc" },
                    { 297, 450, "Internetworking", "test desc" },
                    { 298, 450, "Advanced Internetworking", "test desc" },
                    { 299, 450, "End-to-End Protocols", "test desc" },
                    { 300, 450, "Congestion Control", "test desc" },
                    { 301, 450, "Network Security", "test desc" },
                    { 302, 452, "Reconnaissance", "test desc" },
                    { 303, 452, "Footprinting Enumeration", "test desc" },
                    { 304, 452, "Vulnerability Analysis", "test desc" },
                    { 305, 452, "Exploitation", "test desc" },
                    { 306, 452, "Gaining Access", "test desc" },
                    { 307, 452, "Privilege Escalation", "test desc" },
                    { 308, 452, "Post-Exploitation", "test desc" },
                    { 309, 452, "Persistence and Clearing Tracks", "test desc" },
                    { 310, 452, "Web Interception, Analysis and Exploitation", "test desc" },
                    { 311, 452, "Burp Suite", "test desc" },
                    { 312, 452, "SQL Injection", "test desc" },
                    { 313, 452, "Cross-Site Scripting (XSS) and Cross-Site Request Forgery (CSRF)", "test desc" },
                    { 314, 452, "Malware Analysis", "test desc" },
                    { 315, 452, "Wireless, Cloud and IoT Attack", "test desc" },
                    { 316, 452, "AI-Powered Ethical Hacking", "test desc" },
                    { 317, 452, "Reporting and Documentation", "test desc" },
                    { 318, 456, "Big Data Fundamentals", "test desc" },
                    { 319, 456, "Types of Attributes", "test desc" },
                    { 320, 456, "Properties of Attribute Values", "test desc" },
                    { 321, 456, "Types of Data", "test desc" },
                    { 322, 456, "Data Quality", "test desc" },
                    { 323, 456, "Sampling", "test desc" },
                    { 324, 456, "Data Normalization", "test desc" },
                    { 325, 456, "Data Cleaning", "test desc" },
                    { 326, 456, "Similarity Measures", "test desc" },
                    { 327, 456, "Feature Selection", "test desc" },
                    { 328, 456, "Instance Selection", "test desc" },
                    { 329, 456, "Data Visualization", "test desc" },
                    { 330, 456, "Data Collection", "test desc" },
                    { 331, 456, "Apriori Algorithm", "test desc" },
                    { 332, 456, "Association Pattern Evaluation", "test desc" },
                    { 333, 456, "Clustering", "test desc" },
                    { 334, 456, "K-Nearest Neighbor Algorithm", "test desc" },
                    { 335, 456, "K-Mean Algorithm", "test desc" },
                    { 336, 456, "Cross Evaluation", "test desc" },
                    { 337, 456, "F1-Score", "test desc" },
                    { 338, 457, "Neural Network Fundamentals", "test desc" },
                    { 339, 457, "Python for Machine Learning", "test desc" },
                    { 340, 457, "Weka Explorer", "test desc" },
                    { 341, 457, "Weka Experimenter", "test desc" },
                    { 342, 457, "KnowledgeFlow", "test desc" },
                    { 343, 457, "Preliminaries in Machine Learning", "test desc" },
                    { 344, 457, "Notations", "test desc" },
                    { 345, 457, "Perceptron", "test desc" },
                    { 346, 457, "Overview of Neural Network", "test desc" },
                    { 347, 457, "Perceptron Convergence Theorem", "test desc" },
                    { 348, 457, "Multi-Layer Perceptron", "test desc" },
                    { 349, 457, "Gradient Descent", "test desc" },
                    { 350, 457, "Backpropagation", "test desc" },
                    { 351, 457, "Overfitting vs Generalization", "test desc" },
                    { 352, 457, "Network Design", "test desc" },
                    { 353, 457, "Universal Approximation Theorem", "test desc" },
                    { 354, 457, "Classification vs Regression", "test desc" },
                    { 355, 457, "Time-Series Prediction", "test desc" },
                    { 356, 457, "Data Preprocessing", "test desc" },
                    { 357, 457, "Evolutionary Learning", "test desc" },
                    { 358, 457, "Genetic Algorithms Applications", "test desc" },
                    { 359, 457, "GA Schemata Theorem", "test desc" },
                    { 360, 457, "LVQ", "test desc" },
                    { 361, 457, "SOM", "test desc" },
                    { 362, 457, "Cluster Analysis", "test desc" },
                    { 363, 460, "Android Studio Fundamentals with Java", "test desc" },
                    { 364, 460, "Firebase Fundamentals", "test desc" },
                    { 365, 460, "XML", "test desc" },
                    { 366, 460, "Layout Design", "test desc" },
                    { 367, 460, "Design Pattern", "test desc" },
                    { 368, 460, "Online Data Storage", "test desc" },
                    { 369, 460, "Control Flow Diagrams", "test desc" },
                    { 370, 460, "MVC Design Pattern", "test desc" },
                    { 371, 460, "Data Flow Diagram (DFD)", "test desc" },
                    { 372, 460, "Easy-to-Use Graphical User Interface (GUI)", "test desc" },
                    { 373, 465, "Introduction to Computing with Python", "test desc" },
                    { 374, 465, "Symbolic Computing", "test desc" },
                    { 375, 465, "Plotting and Visualization", "test desc" },
                    { 376, 465, "Equation Solving", "test desc" },
                    { 377, 465, "Optimization", "test desc" },
                    { 378, 465, "Interpolation", "test desc" },
                    { 379, 465, "Integration", "test desc" },
                    { 380, 465, "Sparse Matrices and Graphs", "test desc" },
                    { 381, 465, "Data Processing and Analysis", "test desc" },
                    { 382, 465, "Statistical Modeling", "test desc" },
                    { 383, 465, "Machine Learning", "test desc" },
                    { 384, 465, "Bayesian Statistics", "test desc" },
                    { 385, 465, "Signal Processing", "test desc" },
                    { 386, 466, "Augmented Reality Concepts", "test desc" },
                    { 387, 466, "Mixed Reality", "test desc" },
                    { 388, 466, "Virtual Reality", "test desc" },
                    { 389, 466, "Extended Reality", "test desc" },
                    { 390, 466, "Virtual Reality Programming", "test desc" },
                    { 391, 466, "Analyzing Issues of Virtual Reality Technology and Their Applications", "test desc" },
                    { 392, 466, "Human-Computer Interaction", "test desc" },
                    { 393, 466, "Measurements in Human-Computer Interaction for Virtual Reality Systems", "test desc" },
                    { 394, 466, "Exploring Researches in Virtual Reality", "test desc" },
                    { 395, 466, "Designing experimental Study Structures and Experimental Procedures", "test desc" },
                    { 396, 466, "Developing Virtual Reality Study", "test desc" },
                    { 397, 467, "Introduction to Statistics", "test desc" },
                    { 398, 467, "Data Analysis", "test desc" },
                    { 399, 467, "Comprehensive Overview of Statistics", "test desc" },
                    { 400, 467, "The R Environment", "test desc" },
                    { 401, 467, "Exploring Data with Graphs", "test desc" },
                    { 402, 467, "Exploring Assumptions", "test desc" },
                    { 403, 467, "Correlation", "test desc" },
                    { 404, 467, "Linear Regression", "test desc" },
                    { 405, 467, "Logistic Regression", "test desc" },
                    { 406, 467, "Means", "test desc" },
                    { 407, 467, "Covariance", "test desc" },
                    { 408, 467, "Formulate Hypothesis of Generic Data", "test desc" },
                    { 409, 470, "Operating Systems Fundamentals", "test desc" },
                    { 410, 470, "Overview of Contemporary Operating Systems", "test desc" },
                    { 411, 470, "UNIX-based Systems Fundamentals", "test desc" },
                    { 412, 470, "Processes", "test desc" },
                    { 413, 470, "Threads", "test desc" },
                    { 414, 470, "CPU Scheduling", "test desc" },
                    { 415, 470, "Main Memory", "test desc" },
                    { 416, 470, "Mass Storage Systems", "test desc" },
                    { 417, 470, "File System Interfaces", "test desc" },
                    { 418, 471, "Overview of Optimization Problems", "test desc" },
                    { 419, 471, "Discrete vs Continuous Optimization", "test desc" },
                    { 420, 471, "Combinatorial Optimization", "test desc" },
                    { 421, 471, "Single vs Multi-Objective Optimization", "test desc" },
                    { 422, 471, "Stochastic Optimization", "test desc" },
                    { 423, 471, "Least Squares", "test desc" },
                    { 424, 471, "Linear Optimization", "test desc" },
                    { 425, 471, "Convex Optimization", "test desc" },
                    { 426, 471, "Non-Linear Optimization", "test desc" },
                    { 427, 471, "Local vs Global Optimization", "test desc" },
                    { 428, 471, "Local Search & Hill Climbing", "test desc" },
                    { 429, 471, "Tabu Search", "test desc" },
                    { 430, 471, "Simulated Annealing", "test desc" },
                    { 431, 471, "Monte Carlo Methods", "test desc" },
                    { 432, 471, "Genetic and Evolutionary Algorithms", "test desc" },
                    { 433, 471, "Swarm Intelligence & Particle Swarm Optimization (PSO)", "test desc" },
                    { 434, 471, "Artificial Bee Colony (ABC)", "test desc" },
                    { 435, 471, "Firefly Algorithm (FA)", "test desc" },
                    { 436, 471, "Whale Optimization & Grasshopper Algorithm", "test desc" },
                    { 437, 471, "Differential Evolution (DE)", "test desc" },
                    { 438, 473, "Motivations for Parallel Processing", "test desc" },
                    { 439, 473, "Parallel Computer Architectures", "test desc" },
                    { 440, 473, "Multicore Programming with OpenMP", "test desc" },
                    { 441, 473, "Massively Parallel Architectures with CUDA", "test desc" },
                    { 442, 473, "Message Passing Programming with MPI", "test desc" },
                    { 443, 473, "Performance Analysis", "test desc" },
                    { 444, 473, "Parallel Backtracking and Branch-and-Bound", "test desc" },
                    { 445, 473, "Parallel Divide and Conquer", "test desc" },
                    { 446, 473, "Parallel Sorting and Searching", "test desc" },
                    { 447, 473, "Parallelism in Data Mining and AI", "test desc" },
                    { 448, 473, "Computational Intelligence and Scientific Computing", "test desc" },
                    { 449, 480, "Software Development Life Cycle (SDLC) Methodologies", "test desc" },
                    { 450, 480, "Project Planning", "test desc" },
                    { 451, 480, "Analysis", "test desc" },
                    { 452, 480, "Design", "test desc" },
                    { 453, 480, "Testing", "test desc" },
                    { 454, 480, "Implementation", "test desc" },
                    { 455, 481, "Requirements Gathering", "test desc" },
                    { 456, 481, "Designing", "test desc" },
                    { 457, 481, "Modeling", "test desc" },
                    { 458, 481, "Implementation", "test desc" },
                    { 459, 481, "Software Testing", "test desc" },
                    { 460, 481, "Presentation", "test desc" },
                    { 461, 489, "Ethics Case of Trending Technologies", "test desc" },
                    { 462, 489, "Professional Responsibility", "test desc" },
                    { 463, 489, "Computer Technology, Culture and Society", "test desc" },
                    { 464, 489, "Computer Crime", "test desc" },
                    { 465, 489, "Software Piracy", "test desc" },
                    { 466, 489, "Patents and Copyrights", "test desc" },
                    { 467, 489, "Global Implications", "test desc" },
                    { 468, 489, "Internet Security", "test desc" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Topics",
                keyColumn: "TopicId",
                keyValue: 468);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 102,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 105,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 107,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 109,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 110,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 111,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 112,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 301,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 302,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 311,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 312,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 325,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 351,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 361,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 362,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 367,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 370,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 380,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 420,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 427,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 428,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 430,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 440,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 445,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 446,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 450,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 452,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 456,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 457,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 460,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 465,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 466,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 467,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 470,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 471,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 473,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 480,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 481,
                column: "CourseDesc",
                value: "test desc");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 489,
                column: "CourseDesc",
                value: "test desc");
        }
    }
}
