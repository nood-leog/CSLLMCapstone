using CSLLMCapstone.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace CSLLMCapstone.Data
{
    public class StudyContext : DbContext
    {
        public StudyContext(DbContextOptions<StudyContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instance> Instances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ensure email is unique
            modelBuilder.Entity<User>()
                .HasIndex(u => u.CwuEmail)
                .IsUnique();

            // Add the seed data for Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 102, Title = "Health and Technology", 
                    CourseDesc = "CS 102 guides students to analyze the impact of health factors through construction of a personal health index calculator and create health " +
                    "analysis tools with instantaneous updating. Students will also evaluate the pros and cons of technology in the health field. Course topics will " +
                    "vary but may include Big Tech, Video games, Telemedicine, Artificial intelligence, Robotics, 5G, Deep web, Virtual reality, Music technology, " +
                    "Wearables, and Ethics. The course emphasizes exploration of new methods of obtaining, analyzing, and reporting information in health-technology. " +
                    "Students will engage through written papers and group discussions, and create their own personal health index calculator through simple, " +
                    "beginning-level programming."
                },

                new Course { CourseId = 105, Title = "The Logical Basis of Computing", 
                    CourseDesc = "CS 105 guides students in developing mathematical and quantitative reasoning skills by learning the fundamentals of computer programming. " +
                    "Learning to program helps students develop enhanced critical thinking skills, grounded in mathematical logic and quantitative reasoning. " +
                    "Students gain an understanding of possible connections between technology and artistic expression. Course goals include students demonstrating " +
                    "knowledge of the inner workings of the digital revolution, composing the mathematical logic required to solve problems with programming code, " +
                    "and demonstrating mathematical and quantitative reasoning skills by identifying the programming code needed to solve problems of increasing complexity."
                },

                new Course { CourseId = 107, Title = "Make a Game with Computer Science", 
                    CourseDesc = "CS 107 focuses on the complete principles of software development, guiding students through the full lifecycle from requirement specification " +
                    "to deployment and maintenance. The primary goal is to foster the ability to apply both theoretical and practical knowledge to develop various " +
                    "software tools, packages, or libraries addressing a specific problem statement. Students will gain hands-on experience in designing, debugging, " +
                    "and executing programs in modern programming languages such as Java. The course uses Unreal Engine 4.24.xx."
                },

                new Course { CourseId = 109, Title = "Quantitative Reasoning Using Python", 
                    CourseDesc = "CS 109 explores quantitative and statistical processes by implementing the programming language Python. Students will apply procedures from " +
                    "Python's data visualization libraries to present data in formats including, but not limited to, graphs, histograms, and bar charts. " +
                    "They will evaluate these mathematical forms to formulate meaningful conclusions. In addition to quantitative and statistical processes, " +
                    "students will learn programming skills to develop enhanced critical thinking skills, grounded in logic and reason. Course topics include " +
                    "Introduction to Python, Data visualization, Classes and Object Oriented Programming (OOP), Stochastic programs, probability and distributions, " +
                    "Sampling and confidence intervals, Understanding experimental data, Hypothesis checking, and Conditional probability and Bayesian statistics."
                },

                new Course { CourseId = 110, Title = "Programming Fundamentals I", 
                    CourseDesc = "CS110 teaches students the basics of writing Java programs to solve problems of increasing complexity. Specific learner outcomes include " +
                    "implementing sequential programming, decision statements, repetition constructs (including nested loops), and arithmetic operators. " +
                    "Students will also implement Java primitive data type variables, file processing, methods to modularize programs, class definitions, and arrays " +
                    "and objects of the ArrayList class."
                },

                new Course { CourseId = 111, Title = "Programming Fundamentals II", 
                    CourseDesc = "CS 111 provides an in-depth exploration of intermediate programming concepts in Java, building upon the foundations of " +
                    "Programming Fundamentals I. Students advance their skills in object-oriented programming, specifically focusing on inheritance, polymorphism, and " +
                    "abstract classes to create scalable and reusable code. The course also reinforces core logic while introducing complex topics like " +
                    "Advanced File I/O, including object serialization and random access files, alongside a thorough introduction to Recursion. Beyond command-line " +
                    "applications, students are expected to design and implement Graphical User Interfaces (GUIs) using Event Listeners and Layout Managers. " +
                    "This comprehensive approach ensures students understand how to transition from basic logic to building robust, interactive software systems " +
                    "equipped with professional error-handling and debugging techniques."
                },

                new Course { CourseId = 112, Title = "Introduction to Data Science in Python", 
                    CourseDesc = "CS112 focuses on the foundations of data science and its applications, including how the data science process can be used to address " +
                    "real-life problems. Students will identify key characteristics of Python programming, including syntax, semantics, debugging, and data science packages. " +
                    "The course aims to resolve compilation warnings and error messages in Python and demonstrate full understanding of the Python programming paradigms in " +
                    "respect to the data science paradigm."
                },

                new Course { CourseId = 301, Title = "Data Structures", 
                    CourseDesc = "CS 301 explores data structures, algorithms for manipulating them, and the practical problems of implementing those structures in real " +
                    "programming languages and environments. Attention is paid to the analysis of algorithms to characterize their worst and average case requirements for " +
                    "running time and memory. The course should expand the students' toolbox of basic techniques for manipulating data at both the conceptual and the concrete level. " +
                    "Topics will proceed through classic data structures and Java-based containers, exploring the use and implementation of each. Motivating problems will be " +
                    "drawn from a variety of application areas."
                },

                new Course { CourseId = 302, Title = "Advanced Data Structures and File Processing", 
                    CourseDesc = "CS 302 continues the exploration of data structures, algorithms for manipulating them, and implementing those structures in real " +
                    "programming languages and environments. This course will focus on the analysis of algorithms to characterize worst and average case requirements " +
                    "for running time and memory. Students will be able to apply basic complexity measures and demonstrate the correct use and application of " +
                    "various data structures, including trees, hashing, and graphs. The primary goal is to expand the student's toolbox of basic techniques for " +
                    "manipulating data at both the conceptual and concrete levels."
                },

                new Course { CourseId = 311, Title = "Computer Architecture I", 
                    CourseDesc = "CS 311 is an introduction to computer architecture focusing on assembly language programming on the x86-64 bit architecture. " +
                    "The course uses the yasm assembly compiler and the ebe interface. Students will learn to create and modify programs of significant size " +
                    "using 64-bit Assembly language. Course topics include numbers type conversions, computer memory architecture, registers in 32/64-bit modes, " +
                    "arithmetic, bit operations, branching, looping, and functions in Assembly. The primary goal is to gain hands-on experience in Assembly language programming."
                },

                new Course { CourseId = 312, Title = "Computer Architecture II", 
                    CourseDesc = "CS 312 focuses on distinguishing between computer architecture and computer organization, and using Boolean algebra to solve basic " +
                    "logic problems. Students will describe the operation of CPU, memory, bus, and I/O, and compare different instruction sets for processors. " +
                    "The course will cover topics such as Digital Logic, Cache Memory, and Instruction Sets. The primary goal is for students to comprehend different " +
                    "gate and logic-based structures and analyze various computer architectures. Students will gain hands-on experience using software like MultiMedia Logic and Java."
                },

                new Course { CourseId = 325, Title = "Technical Writing in Computer Science", 
                    CourseDesc = "CS 325 is a writing-intensive, upper-division course that prepares students for professional communication within the computer science field. " +
                    "The curriculum focuses on mastering technical writing, editing, and ethical practices, with a heavy emphasis on APA documentation. " +
                    "Students engage in a workshop-oriented environment, applying their skills through hands-on assignments such as technical summaries, " +
                    "research proposals, annotated bibliographies, and professional presentations. By utilizing software tools like LaTeX and Microsoft Office, " +
                    "students learn to produce high-quality documentation that meets industry standards. The course requires significant effort outside of class to " +
                    "refine professional-level writing and mechanical proficiency."
                },

                new Course { CourseId = 351, Title = "Web Development Technologies II", 
                    CourseDesc = "CS 351 provides an in-depth exploration of server-side technologies essential for modern web software development. " +
                    "Students advance their skills in programming languages and database access, specifically focusing on designing and creating " +
                    "dynamic web applications using PHP and SQL. The course also reinforces client-side mastery of XHTML, CSS, and JavaScript, while introducing " +
                    "complex topics like e-commerce and system testing. Beyond technical implementation, students are expected to articulate ethical positions " +
                    "on contemporary web issues and deliver professional oral presentations on their designs. This comprehensive approach ensures students " +
                    "understand both the functional and societal impacts of web technologies."
                },

                new Course { CourseId = 361, Title = "Principles of Language Design I", 
                    CourseDesc = "CS 361 introduces the fundamental principles of programming language design and software construction, primarily using the " +
                    "C programming language. The course covers essential topics including data types, operators, expressions, functions, and scope. " +
                    "Students delve into complex concepts such as pointers, arrays, strings, dynamic memory management, and structures. By following a " +
                    "structured approach to branching, iteration, and input/output, learners gain a deep understanding of how languages are implemented and utilized. " +
                    "Through these technical foundations, the course aims to develop a student's ability to design efficient software and understand the underlying mechanics " +
                    "of various programming paradigms."
                },

                new Course { CourseId = 362, Title = "Principles of Language Design II", 
                    CourseDesc = "CS 362 explores the fundamental concepts of programming languages by examining design issues, syntax description methods, and semantic models. " +
                    "Students critically compare design alternatives across various common languages and study implementation methods integrated throughout the class. " +
                    "Key topics include abstract data types, parallel processing, object-oriented programming, exception handling, and functional and logic programming. " +
                    "Upon completion, students will be able to apply formal methods of syntax, such as attribute grammars, and understand static and dynamic semantics. " +
                    "The course ultimately empowers students to compare computer languages effectively and demonstrate advanced knowledge in naming and language constructs."
                },

                new Course { CourseId = 367, Title = "Advanced Visual Basic Programming", 
                    CourseDesc = "CS 367 provides a comprehensive introduction to the fundamental principles of software engineering, focusing on the systematic processes " +
                    "required to build high-quality software systems. Students explore the Software Development Life Cycle (SDLC), covering essential phases such as " +
                    "requirements elicitation, system analysis, and architectural design. The curriculum emphasizes Object-Oriented Analysis and Design (OOAD) using UML " +
                    "for modeling and documentation. Additionally, the course addresses practical industry concerns, including project management, software testing strategies, " +
                    "and the ethical implications of technology. Through collaborative projects and technical writing, students learn to translate complex user needs " +
                    "into robust, maintainable software solutions."
                },

                new Course { CourseId = 370, Title = "Introduction to Linux", 
                    CourseDesc = "CS 370 provides a comprehensive introduction to the Linux operating system, focusing on its architecture, command-line interface, " +
                    "and administrative capabilities. Students explore the fundamental philosophy of Linux, learning to navigate the file system, manage permissions, " +
                    "and utilize shell scripting for task automation. The course curriculum covers essential topics such as process management, software installation, " +
                    "and system configuration, emphasizing practical, hands-on experience. Students also delve into networking basics and security protocols within the " +
                    "Linux environment. By the end of the term, learners will have developed the technical proficiency required to manage Linux-based systems effectively " +
                    "in both personal and professional computing contexts."
                },

                new Course { CourseId = 380, Title = "Introduction to Software Engineering", 
                    CourseDesc = "CS 380 introduces the fundamental principles and professional practices of software engineering, with a core focus on object-oriented analysis " +
                    "and design. Students explore essential methodologies, including the use of design patterns (specifically Java patterns) and the implementation of " +
                    "robust testing strategies. The curriculum covers the entire Software Development Lifecycle, from project planning and requirements gathering using UML diagrams " +
                    "to version control and final execution. Beyond technical skills, the course emphasizes human-centric elements such as customer interaction, team organization, " +
                    "and conflict resolution. Through collaborative projects and progress presentations, students gain practical experience in managing large-scale resources " +
                    "and delivering quality software solutions."
                },

                new Course { CourseId = 420, Title = "Database Management Systems", 
                    CourseDesc = "CS 420 provides an in-depth exploration of the logical aspects of database processing and the concepts of organizing data into integrated databases. " +
                    "Students examine various structural approaches, including hierarchical, network, and relational models. The curriculum focuses on translating complex " +
                    "user requirements into valid database designs using Entity/Relationship (E/R) modeling and relational algebra. Practical skills are emphasized through " +
                    "the mastery of Structured Query Language (SQL) and the application of normalization principles via functional dependencies. By utilizing industry-standard tools " +
                    "like MySQL Workbench, students learn to identify and implement high-quality relational database designs. The course ensures that learners can " +
                    "effectively manage data integrity and optimize database organization for modern software applications."
                },

                new Course { CourseId = 427, Title = "Algorithm Analysis", 
                    CourseDesc = "CS 427 provides a rigorous study of algorithm design, algorithm complexity analysis, and problem complexity analysis. " +
                    "The course explores fundamental problem-solving strategies, including divide-and-conquer, dynamic programming, greedy algorithms, backtracking, and " +
                    "branch-and-bound techniques. Students learn to evaluate the efficiency of algorithms using asymptotic notation, focusing on both time and " +
                    "space complexity for iterative and recursive processes. By applying these strategies to traditional and non-traditional computing domains, " +
                    "students develop high-level critical thinking and technical skills. The curriculum emphasizes mastering specific strategies to solve complex mathematical and " +
                    "computational problems efficiently."
                },

                new Course { CourseId = 428, Title = "Introduction to Graph Algorithm", 
                    CourseDesc = "CS 428 offers a comprehensive introduction to the field of graph algorithms, focusing on the identification, analysis, and " +
                    "practical solution of algorithmic graph problems. The curriculum spans fundamental concepts, including graph terminology and implementation variants like " +
                    "directed, undirected, and weighted graphs. Students master essential search techniques such as DFS, BFS, and Maximum Cardinality Search, while " +
                    "exploring efficiently solvable problems like shortest paths (A* and Floyd-Warshall), Max-Flow, and Min-Cut. Additionally, the course delves into " +
                    "advanced topics such as graph coloring, isomorphism, and planarity. Through lab assignments and quizzes, students develop the skills necessary to " +
                    "apply these complex mathematical structures to real-world computing challenges."
                },

                new Course { CourseId = 430, Title = "Cybersecurity", 
                    CourseDesc = "CS 430 provides a comprehensive overview of computer security, spanning from fundamental principles to contemporary security trends and " +
                    "the evolving threat environment. The curriculum covers critical areas such as general security principles, operational and organizational controls, and " +
                    "the vital human element in cybersecurity. Students delve into technical topics including cryptography, physical security concepts, and network fundamentals. " +
                    "Additionally, the course explores IT infrastructure security practices, authentication mechanisms, remote access, and wireless security. " +
                    "A significant focus is placed on understanding and implementing methods to counter cyber-attacks in modern computer systems. " +
                    "By combining theoretical knowledge with practical defense strategies, students develop the skills necessary to protect digital assets and maintain " +
                    "secure computing environments."
                },

                new Course { CourseId = 440, Title = "Computer Graphics", 
                    CourseDesc = "CS 440 introduces the fundamental concepts, algorithms, and challenges within the field of computer graphics, along with a survey of " +
                    "modern graphics software and hardware systems. Students develop the technical ability to write graphics programs using OpenGL, mastering both 2-D and " +
                    "3-D techniques. The curriculum emphasizes the mathematical foundations of graphics, including vector manipulation, dot and cross products, and " +
                    "matrix techniques for rotation, scaling, and translation. Additionally, students explore advanced topics such as vector clipping, scientific visualization, " +
                    "and image processing. Through hands-on programming assignments involving rosettes, arcs, and clipping algorithms, learners gain practical experience " +
                    "in rendering complex visual data and managing aspect ratios in dynamic windows."
                },

                new Course { CourseId = 445, Title = "Data and Information Visualization", 
                    CourseDesc = "CS 445 explores the principles of Data Visualization, focusing on transforming complex data into insightful visual representations. " +
                    "Students learn to utilize tools like Jupyter Notebooks, Matplotlib, and Seaborn to create effective marks and channels for data abstraction. " +
                    "The curriculum covers task abstraction, spatial fields, and the arrangement of networks and trees. Key topics include color theory, 3D graph practice, " +
                    "and advanced techniques such as Principal Component Analysis (PCA) and map visualization. Through lab assignments and a multi-phase final project, " +
                    "students master rules of thumb for design and gain practical experience in visual knowledge discovery and machine learning integration."
                },

                new Course { CourseId = 446, Title = "User Interface Design and Development", 
                    CourseDesc = "CS 446 focuses on the fundamental principles of Human-Computer Interaction (HCI) and the design of effective user interfaces. " +
                    "Using Don Norman's The Design of Everyday Things as a foundation, students explore psychological concepts like affordances, signifiers, and " +
                    "mental models to understand how users interact with technology. The curriculum follows a practical, lab-based approach covering the entire design lifecycle, " +
                    "including requirements gathering, paper prototyping, and computer-based implementation using Visual C#. Students master critical topics such as " +
                    "usability testing, accessibility, information visualization, and graphic design elements like typography and color theory. Through a multi-phase project, " +
                    "learners gain hands-on experience in building and evaluating interfaces that are intuitive, safe, and efficient."
                },

                new Course { CourseId = 450, Title = "Computer Network and Data Communications", 
                    CourseDesc = "CS 450 provides a comprehensive examination of the technical foundations of networking and data communication. " +
                    "The course focuses on critical concepts such as device and network protocols, network configurations, and infrastructure topologies. " +
                    "Students analyze the nature of protocol layering and identify the primary standards bodies that govern global networking. " +
                    "The curriculum also delves into advanced topics including encryption, data compression, and network security. " +
                    "Practical objectives include identifying LAN architectures and evaluating the messaging mechanisms of various network operating systems. " +
                    "By the end of the course, students will be equipped to analyze the functionality of modern computer networks and understand the fundamentals of " +
                    "wide area versus local area communications."
                },

                new Course { CourseId = 452, Title = "Ethical Hacking and Penetration Testing for Computer Science", 
                    CourseDesc = "CS 452 focuses on ethical offensive security techniques. It covers exploiting vulnerabilities like SQL injection, input validation flaws, " +
                    "and scripting attacks. The curriculum is structured to cover the full process, including reconnaissance, vulnerability scanning, and penetration testing. " +
                    "Students will use DevOps security tools to simulate and analyze real-world attacks. Key topics include Enumeration, Vulnerability Analysis, Exploitation, " +
                    "Privilege Escalation, and Post-Exploitation. Further content covers Web Interception, Malware Analysis, Wireless, Cloud & IoT Attacks, " +
                    "AI-powered ethical hacking, and professional reporting."
                },

                new Course { CourseId = 456, Title = "Data Mining", 
                    CourseDesc = "CS456 studies algorithms and computational paradigms to find patterns, regularities, and perform prediction in databases. " +
                    "It is a key element of Knowledge Discovery, covering the full process from data selection, cleaning, and coding to using statistical and " +
                    "machine learning techniques, and visualization. The course emphasizes Machine Learning methods as real knowledge discovery tools. " +
                    "Important related technologies, such as data warehousing, are also discussed. Students will gain proficiency in techniques like classification, " +
                    "clustering, association rule mining, and regression, and apply them to real-world problems using recent Data Mining software. " +
                    "The main goal is to extract useful knowledge from raw data."
                },

                new Course { CourseId = 457, Title = "Computational Intelligence and Machine Learning", 
                    CourseDesc = "CS 457 introduces intelligent systems from a machine learning perspective, focusing on the fundamentals of Computational Intelligence and " +
                    "Machine Learning (CI & ML) models. Typical topics include neural networks, supervised and unsupervised learning, clustering, support vector machines, " +
                    "evolutionary learning, deep learning, and convolutional neural networks. Upon completion, students will understand core CI & ML models, implement algorithms, " +
                    "and apply techniques to solve classification, regression, prediction, and optimization problems. Practical application is emphasized through three group " +
                    "projects and an individual final project. Students are encouraged to use software tools like Python, Anaconda, and Weka for implementation."
                },

                new Course { CourseId = 460, Title = "Software Engineering for Mobile Devices", 
                    CourseDesc = "CS 460 provides a comprehensive introduction to the principles and practices of database systems, focusing on both traditional and modern " +
                    "data management techniques. The curriculum covers fundamental concepts of relational database models, including relational algebra, SQL, and database design " +
                    "using entity-relationship and functional dependency modeling. Students will also explore advanced topics such as NoSQL databases, transaction management, " +
                    "concurrency control, and data warehousing. A major component of the course is hands-on experience in designing, implementing, and querying a database system. " +
                    "The course objective is to enable students to effectively design and manage robust, scalable, and secure data storage solutions for various applications."
                },

                new Course { CourseId = 465, Title = "Scientific Computing", 
                    CourseDesc = "CS 465 covers different topics in scientific computing, including numerical computation, mathematical modeling, statistical modeling, optimization, " +
                    "and machine learning. Taught asynchronously, the curriculum is designed to help students formulate techniques required to implement and use " +
                    "mathematical algorithms to a variety of complex computational problems. Key content areas include an introduction to computing with Python, symbolic computing, " +
                    "plotting and visualization, equation solving, and various advanced topics like sparse matrices, data processing, Bayesian statistics, and signal processing. " +
                    "Students will demonstrate their knowledge by applying coding skills to develop solutions using scientific computing libraries and tools. " +
                    "Assessment consists of five lab exercises with both written and coding parts, and a final project is assigned only to CS 565 students."
                },

                new Course { CourseId = 466, Title = "Virtual Reality", 
                    CourseDesc = "CS 466 is an introduction to virtual reality application development and human-computer interaction research. " +
                    "The course covers essential topics including 3D programming, virtual reality application domains, 3D interaction designs, and the development of " +
                    "human-computer interaction research papers. Students will also explore experimental study designs. This is a hybrid class with asynchronous online assignments " +
                    "and real-time meetings for demonstrations, discussions, and projects. The curriculum uses the Unity 3D game engine for programming and requires a smartphone " +
                    "and a Google Cardboard-like VR Viewer. The course integrates a group term project, worth 40% of the grade, where student teams develop a " +
                    "VR-related human-computer interaction research paper."
                },

                new Course { CourseId = 467, Title = "Computational Statistics", 
                    CourseDesc = "CS 467 explores the interface between statistics and computer science, encompassing computational and graphical approaches to solving statistical " +
                    "problems. Students will learn to manipulate and analyze data, design simulated experiments, and use resampling methods. The primary focus is on the " +
                    "in-depth understanding and use of the R Language, the predominate software platform for statistical analysis. The curriculum covers key topics like correlation, " +
                    "linear regression, and logistic regression. The course includes four research seminars and two complex programming projects involving background research, " +
                    "coding, and analysis of results."
                },

                new Course { CourseId = 470, Title = "Operating Systems", 
                    CourseDesc = "CS 470 provides a fundamental understanding of the structure and function of contemporary operating systems, with a primary focus on " +
                    "UNIX-based systems, including Linux and Windows. It begins with an architectural overview, followed by an in-depth exploration of major components " +
                    "like processes, threads, memory management, and file I/O. Students will assess and critically analyze various CPU scheduling algorithms, recognizing " +
                    "their advantages and limitations. Through practical assessments, students will demonstrate the ability to discern and articulate different strategies " +
                    "within the operating system framework. The goal is to prepare students for advanced academic study or professional pursuits in computer science."
                },

                new Course { CourseId = 471, Title = "Optimization", 
                    CourseDesc = "CS 471 is an intensive study of operating systems principles and implementation. Key topics include process and thread management, " +
                    "CPU scheduling algorithms, synchronization, deadlock prevention, and concurrent programming. A major focus is on memory management, covering virtual memory, " +
                    "paging, and segmentation techniques. The curriculum also delves into file system structure, I/O systems, and the fundamentals of system security. " +
                    "Students will gain practical experience in system-level programming and apply theoretical concepts to understand the design and trade-offs of modern " +
                    "operating systems. The core objective is to equip students with the knowledge to analyze, design, and implement operating system components."
                },

                new Course { CourseId = 473, Title = "Parallel Computing", 
                    CourseDesc = "CS 473 provides a comprehensive study of parallel computing, focusing on the design and implementation of parallel algorithms. " +
                    "Key topics include Parallel Algorithm Design, Shared-Memory Programming with OpenMP, CUDA, Message-Passing Programming (MPI), and Performance Analysis. " +
                    "Students will engage with advanced concepts such as the Sieve of Eratosthenes, Floyd's Algorithm, Document Classification, and Combinatorial Search. " +
                    "The course includes a rigorous laboratory schedule with multiple projects, challenging students to implement concepts in OpenMP, CUDA, and MPI. " +
                    "The course material includes a major technical report and an online book by Ian Foster."
                },

                new Course { CourseId = 480, Title = "Advanced Software Engineering", 
                    CourseDesc = "CS 480 provides advanced principles and practices for the complete software engineering lifecycle. The curriculum covers project management, " +
                    "requirements gathering and specification, design, coding, testing, maintenance, and documentation. Students will study the software product lifecycle, " +
                    "from problem definition and client interaction to deployment. A key focus is on acquiring and integrating concepts like software project management and " +
                    "learning how to prepare essential documentation, such as a Software Requirements Specification. The course emphasizes teamwork and culminates in students " +
                    "working in teams to develop a large software project."
                },

                new Course { CourseId = 481, Title = "Capstone Project", 
                    CourseDesc = "CS 481 focuses on the complete principles of software development, guiding students through the full lifecycle from requirement " +
                    "specification to deployment and maintenance. The primary goal is to foster the ability to apply both theoretical and practical knowledge to develop various " +
                    "software tools, packages, or libraries addressing a specific problem statement. The course content is structured around weekly discussions, " +
                    "five major assignments, and two required presentations (midterm and final). Students will gain hands-on experience in designing, debugging, and " +
                    "executing programs in modern programming languages such as Python, Java, JavaScript, and C++. The project culminates in an oral defense of the developed software."
                },

                new Course { CourseId = 489, Title = "Senior Colloquium", 
                    CourseDesc = "CS489 is an introduction to research in computer science through the investigation of ethical and historical topics in the field. " +
                    "It also includes end-of-major assessment activities. Topics may include AI Ethics, Professional Responsibility, Computer Crime, and Internet Security. " +
                    "Students will research current topics, prepare written reports on ethical or historical topics, and present their research results with critical analysis to the class. " +
                    "A Major Field Test (MFT) is also required for the course."
                }
            );

            // Add the seed data for Topics that reference the Courses
            modelBuilder.Entity<Topic>().HasData(
                // CS 102 Topics
                new Topic { TopicId = 1, CourseId = 102, Name = "Big Tech", TopicDesc = "test desc" },
                new Topic { TopicId = 2, CourseId = 102, Name = "Video Games", TopicDesc = "test desc" },
                new Topic { TopicId = 3, CourseId = 102, Name = "Telemedicine", TopicDesc = "test desc" },
                new Topic { TopicId = 4, CourseId = 102, Name = "AI", TopicDesc = "test desc" },
                new Topic { TopicId = 5, CourseId = 102, Name = "Robotis", TopicDesc = "test desc" },
                new Topic { TopicId = 6, CourseId = 102, Name = "Deep Web", TopicDesc = "test desc" },
                new Topic { TopicId = 7, CourseId = 102, Name = "VR", TopicDesc = "test desc" },
                new Topic { TopicId = 8, CourseId = 102, Name = "Music Technology", TopicDesc = "test desc" },
                new Topic { TopicId = 9, CourseId = 102, Name = "Wearables", TopicDesc = "test desc" },
                new Topic { TopicId = 10, CourseId = 102, Name = "Ethics", TopicDesc = "test desc" },
                // CS 105 Topics
                new Topic { TopicId = 11, CourseId = 105, Name = "Visual Basics Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 12, CourseId = 105, Name = "Mathematical/Logical Basis of Computing", TopicDesc = "test desc" },
                new Topic { TopicId = 13, CourseId = 105, Name = "Quantitative Reasoning", TopicDesc = "test desc" },
                new Topic { TopicId = 14, CourseId = 105, Name = "Social/Political/Ethical Implications of Technological Advancement", TopicDesc = "test desc" },
                new Topic { TopicId = 15, CourseId = 105, Name = "Data Association Implementing Parallel Mapping", TopicDesc = "test desc" },
                new Topic { TopicId = 16, CourseId = 105, Name = "Computational Thinking", TopicDesc = "test desc" },
                new Topic { TopicId = 17, CourseId = 105, Name = "Algorithm Sequencing", TopicDesc = "test desc" },
                new Topic { TopicId = 18, CourseId = 105, Name = "Integrated Development Environment (IDE) Proficiency", TopicDesc = "test desc" },
                // CS 107 Topics
                new Topic { TopicId = 19, CourseId = 107, Name = "Unreal Engine Fundamentals and Software Development", TopicDesc = "test desc" },
                new Topic { TopicId = 20, CourseId = 107, Name = "Elements of a Game", TopicDesc = "test desc" },
                new Topic { TopicId = 21, CourseId = 107, Name = "Designing a Game", TopicDesc = "test desc" },
                new Topic { TopicId = 22, CourseId = 107, Name = "Brainstorming", TopicDesc = "test desc" },
                new Topic { TopicId = 23, CourseId = 107, Name = "Narrative and Backstory", TopicDesc = "test desc" },
                new Topic { TopicId = 24, CourseId = 107, Name = "Scenario", TopicDesc = "test desc" },
                new Topic { TopicId = 25, CourseId = 107, Name = "Storyboard and Script", TopicDesc = "test desc" },
                new Topic { TopicId = 26, CourseId = 107, Name = "Usability and Accessibility", TopicDesc = "test desc" },
                new Topic { TopicId = 27, CourseId = 107, Name = "Ethical/Social/Legal Issues in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 28, CourseId = 107, Name = "Game-based Learning and Gamification", TopicDesc = "test desc" },
                new Topic { TopicId = 29, CourseId = 107, Name = "Gaming Science", TopicDesc = "test desc" },
                new Topic { TopicId = 30, CourseId = 107, Name = "History in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 31, CourseId = 107, Name = "Careers in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 32, CourseId = 107, Name = "Future of Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 33, CourseId = 107, Name = "Rise of Gaming Subcultures", TopicDesc = "test desc" },
                // CS 109 Topics
                new Topic { TopicId = 34, CourseId = 109, Name = "Python Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 35, CourseId = 109, Name = "Data Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 36, CourseId = 109, Name = "Classes and OOP", TopicDesc = "test desc" },
                new Topic { TopicId = 37, CourseId = 109, Name = "Stochastic Programs", TopicDesc = "test desc" },
                new Topic { TopicId = 38, CourseId = 109, Name = "Probability and Distributions", TopicDesc = "test desc" },
                new Topic { TopicId = 39, CourseId = 109, Name = "Sampling and Confidence Intervals", TopicDesc = "test desc" },
                new Topic { TopicId = 40, CourseId = 109, Name = "Understanding Experimental Data", TopicDesc = "test desc" },
                new Topic { TopicId = 41, CourseId = 109, Name = "Hypothesis Checking", TopicDesc = "test desc" },
                new Topic { TopicId = 42, CourseId = 109, Name = "Conditional Probability and Bayesian Statistics", TopicDesc = "test desc" },
                // CS 110 Topics
                new Topic { TopicId = 43, CourseId = 110, Name = "Java Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 44, CourseId = 110, Name = "Decision Structures", TopicDesc = "test desc" },
                new Topic { TopicId = 45, CourseId = 110, Name = "Careers in Gaming", TopicDesc = "test desc" },
                new Topic { TopicId = 46, CourseId = 110, Name = "Repetition", TopicDesc = "test desc" },
                new Topic { TopicId = 47, CourseId = 110, Name = "Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 48, CourseId = 110, Name = "Classes", TopicDesc = "test desc" },
                new Topic { TopicId = 49, CourseId = 110, Name = "Object Oriented Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 50, CourseId = 110, Name = "Arrays and ArrayLists", TopicDesc = "test desc" },
                // CS 111 Topics
                new Topic { TopicId = 51, CourseId = 111, Name = "Static Fields and Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 52, CourseId = 111, Name = "Returning Objects from Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 53, CourseId = 111, Name = "toString Method", TopicDesc = "test desc" },
                new Topic { TopicId = 54, CourseId = 111, Name = "Comparing Objects", TopicDesc = "test desc" },
                new Topic { TopicId = 55, CourseId = 111, Name = "Aggregation", TopicDesc = "test desc" },
                new Topic { TopicId = 56, CourseId = 111, Name = "Copy Constructor", TopicDesc = "test desc" },
                new Topic { TopicId = 57, CourseId = 111, Name = "Null Reference", TopicDesc = "test desc" },
                new Topic { TopicId = 58, CourseId = 111, Name = "Enums", TopicDesc = "test desc" },
                new Topic { TopicId = 59, CourseId = 111, Name = "StringBuilder", TopicDesc = "test desc" },
                new Topic { TopicId = 60, CourseId = 111, Name = "Tokenizing", TopicDesc = "test desc" },
                new Topic { TopicId = 61, CourseId = 111, Name = "Inheritance", TopicDesc = "test desc" },
                new Topic { TopicId = 62, CourseId = 111, Name = "Superclasses", TopicDesc = "test desc" },
                new Topic { TopicId = 63, CourseId = 111, Name = "Overrriding", TopicDesc = "test desc" },
                new Topic { TopicId = 64, CourseId = 111, Name = "Protected Members", TopicDesc = "test desc" },
                new Topic { TopicId = 65, CourseId = 111, Name = "Chains of Inheritance", TopicDesc = "test desc" },
                new Topic { TopicId = 66, CourseId = 111, Name = "Polymorphism", TopicDesc = "test desc" },
                new Topic { TopicId = 67, CourseId = 111, Name = "Abstract Classes", TopicDesc = "test desc" },
                new Topic { TopicId = 68, CourseId = 111, Name = "Exceptions", TopicDesc = "test desc" },
                new Topic { TopicId = 69, CourseId = 111, Name = "Error Handling", TopicDesc = "test desc" },
                new Topic { TopicId = 70, CourseId = 111, Name = "Advanced File I/O", TopicDesc = "test desc" },
                new Topic { TopicId = 71, CourseId = 111, Name = "Binary Files", TopicDesc = "test desc" },
                new Topic { TopicId = 72, CourseId = 111, Name = "Random Access Files", TopicDesc = "test desc" },
                new Topic { TopicId = 73, CourseId = 111, Name = "Object Serialization", TopicDesc = "test desc" },
                new Topic { TopicId = 74, CourseId = 111, Name = "Binary Search", TopicDesc = "test desc" },
                new Topic { TopicId = 75, CourseId = 111, Name = "Recursion", TopicDesc = "test desc" },
                new Topic { TopicId = 76, CourseId = 111, Name = "GUI Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 77, CourseId = 111, Name = "Action Listeners", TopicDesc = "test desc" },
                // CS 112 Topics
                new Topic { TopicId = 78, CourseId = 112, Name = "Python Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 79, CourseId = 112, Name = "Troubleshooting and Debugging in Python", TopicDesc = "test desc" },
                new Topic { TopicId = 80, CourseId = 112, Name = "Identifying Data Science Packages in Python", TopicDesc = "test desc" },
                new Topic { TopicId = 81, CourseId = 112, Name = "Foundations of Data Science", TopicDesc = "test desc" },
                new Topic { TopicId = 82, CourseId = 112, Name = "Real-World Data Science Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 83, CourseId = 112, Name = "Python Programming Paradigms for Data Science", TopicDesc = "test desc" },
                // CS 301 Topics
                new Topic { TopicId = 84, CourseId = 301, Name = "Abstract Data Type (ADT)", TopicDesc = "test desc" },
                new Topic { TopicId = 85, CourseId = 301, Name = "Recursion", TopicDesc = "test desc" },
                new Topic { TopicId = 86, CourseId = 301, Name = "Asymptotic Algorithm Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 87, CourseId = 301, Name = "Big O Notation", TopicDesc = "test desc" },
                new Topic { TopicId = 88, CourseId = 301, Name = "Lists", TopicDesc = "test desc" },
                new Topic { TopicId = 89, CourseId = 301, Name = "Stack", TopicDesc = "test desc" },
                new Topic { TopicId = 90, CourseId = 301, Name = "Queue", TopicDesc = "test desc" },
                new Topic { TopicId = 91, CourseId = 301, Name = "Linked List", TopicDesc = "test desc" },
                new Topic { TopicId = 92, CourseId = 301, Name = "Tree", TopicDesc = "test desc" },
                new Topic { TopicId = 93, CourseId = 301, Name = "Tree Traversal", TopicDesc = "test desc" },
                new Topic { TopicId = 94, CourseId = 301, Name = "Binary Search Tree (BST)", TopicDesc = "test desc" },
                new Topic { TopicId = 95, CourseId = 301, Name = "BST as Dictionary", TopicDesc = "test desc" },
                new Topic { TopicId = 96, CourseId = 301, Name = "Insertion Sort", TopicDesc = "test desc" },
                new Topic { TopicId = 97, CourseId = 301, Name = "Java Collection Framework", TopicDesc = "test desc" },
                new Topic { TopicId = 98, CourseId = 301, Name = "Unit Testing", TopicDesc = "test desc" },
                new Topic { TopicId = 99, CourseId = 301, Name = "Backtracking", TopicDesc = "test desc" },
                // CS 302 Topics
                new Topic { TopicId = 100, CourseId = 302, Name = "Exploration of Data Structures like Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 101, CourseId = 302, Name = "Binary Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 102, CourseId = 302, Name = "Search Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 103, CourseId = 302, Name = "Balanced Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 104, CourseId = 302, Name = "2-3 Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 105, CourseId = 302, Name = "B-trees", TopicDesc = "test desc" },
                new Topic { TopicId = 106, CourseId = 302, Name = "Heaps", TopicDesc = "test desc" },
                new Topic { TopicId = 107, CourseId = 302, Name = "Priority  Queues", TopicDesc = "test desc" },
                new Topic { TopicId = 108, CourseId = 302, Name = "Hashing", TopicDesc = "test desc" },
                new Topic { TopicId = 109, CourseId = 302, Name = "Maps", TopicDesc = "test desc" },
                new Topic { TopicId = 110, CourseId = 302, Name = "Sets", TopicDesc = "test desc" },
                new Topic { TopicId = 111, CourseId = 302, Name = "Matrices", TopicDesc = "test desc" },
                new Topic { TopicId = 112, CourseId = 302, Name = "Graphs", TopicDesc = "test desc" },
                new Topic { TopicId = 113, CourseId = 302, Name = "Basic Complexity Measures to Basic Algorithms and how they were Obtained", TopicDesc = "test desc" },
                new Topic { TopicId = 114, CourseId = 302, Name = "Exploration of Data Structures like Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 115, CourseId = 302, Name = "Basic Understanding of an Abstract Data Types", TopicDesc = "test desc" },
                new Topic { TopicId = 116, CourseId = 302, Name = "Demonstrate the Association  between Abstract Data Types and Basic Java Constructs", TopicDesc = "test desc" },
                // CS 311 Topics
                new Topic { TopicId = 117, CourseId = 311, Name = "Numbers Type Conversions (Different Bases)", TopicDesc = "test desc" },
                new Topic { TopicId = 118, CourseId = 311, Name = "Computer Memory Architecture", TopicDesc = "test desc" },
                new Topic { TopicId = 119, CourseId = 311, Name = "Memory Mapping in 64-bit Mode", TopicDesc = "test desc" },
                new Topic { TopicId = 120, CourseId = 311, Name = "Registers in 32/64-bit Modes", TopicDesc = "test desc" },
                new Topic { TopicId = 121, CourseId = 311, Name = "Arithmetic in Assembly", TopicDesc = "test desc" },
                new Topic { TopicId = 122, CourseId = 311, Name = "Bit Operations", TopicDesc = "test desc" },
                new Topic { TopicId = 123, CourseId = 311, Name = "Branching and Loop in Assembly", TopicDesc = "test desc" },
                new Topic { TopicId = 124, CourseId = 311, Name = "Functions in Assembly", TopicDesc = "test desc" },
                // CS 312 Topics
                new Topic { TopicId = 125, CourseId = 312, Name = "Basic Concepts and Computer Evolution", TopicDesc = "test desc" },
                new Topic { TopicId = 126, CourseId = 312, Name = "Digital Logic", TopicDesc = "test desc" },
                new Topic { TopicId = 127, CourseId = 312, Name = "Computer Evolution/ Performance", TopicDesc = "test desc" },
                new Topic { TopicId = 128, CourseId = 312, Name = "Computer Interconnection", TopicDesc = "test desc" },
                new Topic { TopicId = 129, CourseId = 312, Name = "Cache Memory", TopicDesc = "test desc" },
                new Topic { TopicId = 130, CourseId = 312, Name = "Internal Memory", TopicDesc = "test desc" },
                new Topic { TopicId = 131, CourseId = 312, Name = "Input/Output", TopicDesc = "test desc" },
                new Topic { TopicId = 132, CourseId = 312, Name = "Instruction Sets-1", TopicDesc = "test desc" },
                new Topic { TopicId = 133, CourseId = 312, Name = "Instruction Sets-2", TopicDesc = "test desc" },
                new Topic { TopicId = 134, CourseId = 312, Name = "Processor Structure and Function", TopicDesc = "test desc" },
                new Topic { TopicId = 135, CourseId = 312, Name = "Reduced Instruction Set Computers (RISC)", TopicDesc = "test desc" },
                new Topic { TopicId = 136, CourseId = 312, Name = "Instruction-Level Parallelism and SuperScalar Processors", TopicDesc = "test desc" },
                new Topic { TopicId = 137, CourseId = 312, Name = "General-Purpose Graphic Processing Units (GPGPU) Computing", TopicDesc = "test desc" },
                // CS 325 Topics
                new Topic { TopicId = 138, CourseId = 325, Name = "Writing, Editing, and Ethical Practices in the Field of Computer Science", TopicDesc = "test desc" },
                new Topic { TopicId = 139, CourseId = 325, Name = "Technical Writing for Summaries", TopicDesc = "test desc" },
                new Topic { TopicId = 140, CourseId = 325, Name = "Visualization Tables, Charts, and Graphs", TopicDesc = "test desc" },
                new Topic { TopicId = 141, CourseId = 325, Name = "Cover Letter", TopicDesc = "test desc" },
                new Topic { TopicId = 142, CourseId = 325, Name = "Reviewer's Report", TopicDesc = "test desc" },
                new Topic { TopicId = 143, CourseId = 325, Name = "Procedures", TopicDesc = "test desc" },
                new Topic { TopicId = 144, CourseId = 325, Name = "Research Proposal with Annotated Biblography", TopicDesc = "test desc" },
                new Topic { TopicId = 145, CourseId = 325, Name = "Survey of Literature", TopicDesc = "test desc" },
                new Topic { TopicId = 146, CourseId = 325, Name = "PowerPoint", TopicDesc = "test desc" },
                new Topic { TopicId = 147, CourseId = 325, Name = "Mechanics Exam", TopicDesc = "test desc" },
                // CS 351 Topics
                new Topic { TopicId = 148, CourseId = 351, Name = "Web Development Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 149, CourseId = 351, Name = "HTML and CSS Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 150, CourseId = 351, Name = "JavaScript Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 151, CourseId = 351, Name = "jQuery Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 152, CourseId = 351, Name = "PHP Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 153, CourseId = 351, Name = "Designing and Creating Web Application", TopicDesc = "test desc" },
                new Topic { TopicId = 154, CourseId = 351, Name = "Analyzing Contemporary Issues Related to Web", TopicDesc = "test desc" },
                // CS 361 Topics
                new Topic { TopicId = 155, CourseId = 361, Name = "Types, Operator and Expressions", TopicDesc = "test desc" },
                new Topic { TopicId = 156, CourseId = 361, Name = "Branching and Operator", TopicDesc = "test desc" },
                new Topic { TopicId = 157, CourseId = 361, Name = "Functions, Scope and Extent", TopicDesc = "test desc" },
                new Topic { TopicId = 158, CourseId = 361, Name = "Pointers, Array and Strings", TopicDesc = "test desc" },
                new Topic { TopicId = 159, CourseId = 361, Name = "Dynamic Memory", TopicDesc = "test desc" },
                new Topic { TopicId = 160, CourseId = 361, Name = "Structures and Union", TopicDesc = "test desc" },
                new Topic { TopicId = 161, CourseId = 361, Name = "Input and Output", TopicDesc = "test desc" },
                new Topic { TopicId = 162, CourseId = 361, Name = "Difference from C in C++", TopicDesc = "test desc" },
                new Topic { TopicId = 163, CourseId = 361, Name = "Classes and Objects", TopicDesc = "test desc" },
                // CS 362 Topics
                new Topic { TopicId = 164, CourseId = 362, Name = "Meta language (ML) Basics", TopicDesc = "test desc" },
                new Topic { TopicId = 165, CourseId = 362, Name = "Types", TopicDesc = "test desc" },
                new Topic { TopicId = 166, CourseId = 362, Name = "Polymorphism", TopicDesc = "test desc" },
                new Topic { TopicId = 167, CourseId = 362, Name = "Scope", TopicDesc = "test desc" },
                new Topic { TopicId = 168, CourseId = 362, Name = "Parallel Algorithm Design", TopicDesc = "test desc" },
                new Topic { TopicId = 169, CourseId = 362, Name = "Concurrent Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 170, CourseId = 362, Name = "Eratosthenes", TopicDesc = "test desc" },
                new Topic { TopicId = 171, CourseId = 362, Name = "Floyd's Algorithm", TopicDesc = "test desc" },
                // CS 367 Topics
                new Topic { TopicId = 172, CourseId = 367, Name = "Memory Allocation", TopicDesc = "test desc" },
                new Topic { TopicId = 173, CourseId = 367, Name = "Data Types", TopicDesc = "test desc" },
                new Topic { TopicId = 174, CourseId = 367, Name = "Arithmetic Operators", TopicDesc = "test desc" },
                new Topic { TopicId = 175, CourseId = 367, Name = "Sequential Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 176, CourseId = 367, Name = "Validation of User Input", TopicDesc = "test desc" },
                new Topic { TopicId = 177, CourseId = 367, Name = "Relational Operators", TopicDesc = "test desc" },
                new Topic { TopicId = 178, CourseId = 367, Name = "Boolean Expressions", TopicDesc = "test desc" },
                new Topic { TopicId = 179, CourseId = 367, Name = "Loop Termination Conditions", TopicDesc = "test desc" },
                new Topic { TopicId = 180, CourseId = 367, Name = "Modularize Code by Implementing Functions and Procedures", TopicDesc = "test desc" },
                new Topic { TopicId = 181, CourseId = 367, Name = "File Processing to Maintain a Permanent Record of Data Generated", TopicDesc = "test desc" },
                new Topic { TopicId = 182, CourseId = 367, Name = "Single and Two Dimensional Arrays", TopicDesc = "test desc" },
                new Topic { TopicId = 183, CourseId = 367, Name = "Object-oriented Programming", TopicDesc = "test desc" },
                // CS 370 Topics
                new Topic { TopicId = 184, CourseId = 370, Name = "Installing Linux Distributions", TopicDesc = "test desc" },
                new Topic { TopicId = 185, CourseId = 370, Name = "Command Line", TopicDesc = "test desc" },
                new Topic { TopicId = 186, CourseId = 370, Name = "Shell Expansion", TopicDesc = "test desc" },
                new Topic { TopicId = 187, CourseId = 370, Name = "Pipes and Commands", TopicDesc = "test desc" },
                new Topic { TopicId = 188, CourseId = 370, Name = "Scripting", TopicDesc = "test desc" },
                new Topic { TopicId = 189, CourseId = 370, Name = "Local User Management", TopicDesc = "test desc" },
                new Topic { TopicId = 190, CourseId = 370, Name = "File Security", TopicDesc = "test desc" },
                // CS 380 Topics
                new Topic { TopicId = 191, CourseId = 380, Name = "Software Development Lifecycles", TopicDesc = "test desc" },
                new Topic { TopicId = 192, CourseId = 380, Name = "Project Planning", TopicDesc = "test desc" },
                new Topic { TopicId = 193, CourseId = 380, Name = "Scope", TopicDesc = "test desc" },
                new Topic { TopicId = 194, CourseId = 380, Name = "Requirements", TopicDesc = "test desc" },
                new Topic { TopicId = 195, CourseId = 380, Name = "Use Cases", TopicDesc = "test desc" },
                new Topic { TopicId = 196, CourseId = 380, Name = "Sequence Diagrams", TopicDesc = "test desc" },
                new Topic { TopicId = 197, CourseId = 380, Name = "Design Patterns", TopicDesc = "test desc" },
                new Topic { TopicId = 198, CourseId = 380, Name = "Activity Diagrams", TopicDesc = "test desc" },
                new Topic { TopicId = 199, CourseId = 380, Name = "Class Diagrams", TopicDesc = "test desc" },
                new Topic { TopicId = 200, CourseId = 380, Name = "Test Cases", TopicDesc = "test desc" },
                // CS 420 Topics
                new Topic { TopicId = 201, CourseId = 420, Name = "Databases and Database Users", TopicDesc = "test desc" },
                new Topic { TopicId = 202, CourseId = 420, Name = "Database System Concepts and Architecture", TopicDesc = "test desc" },
                new Topic { TopicId = 203, CourseId = 420, Name = "The Relational Data Model", TopicDesc = "test desc" },
                new Topic { TopicId = 204, CourseId = 420, Name = "Relational Database Constraints", TopicDesc = "test desc" },
                new Topic { TopicId = 205, CourseId = 420, Name = "Basics of Functional Dependencies", TopicDesc = "test desc" },
                new Topic { TopicId = 206, CourseId = 420, Name = "Normalization for Relational Databases", TopicDesc = "test desc" },
                new Topic { TopicId = 207, CourseId = 420, Name = "Data Modeling Using the Entity Relationship (ER) Model", TopicDesc = "test desc" },
                new Topic { TopicId = 208, CourseId = 420, Name = "Relational Algebra", TopicDesc = "test desc" },
                new Topic { TopicId = 209, CourseId = 420, Name = "Relational Calculus", TopicDesc = "test desc" },
                new Topic { TopicId = 210, CourseId = 420, Name = "SQL", TopicDesc = "test desc" },
                // CS 427 Topics
                new Topic { TopicId = 211, CourseId = 427, Name = "Algorithm Design", TopicDesc = "test desc" },
                new Topic { TopicId = 212, CourseId = 427, Name = "Algorithm Complexity Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 213, CourseId = 427, Name = "Problem Complexity Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 214, CourseId = 427, Name = "Divide-and-Conquer", TopicDesc = "test desc" },
                new Topic { TopicId = 215, CourseId = 427, Name = "Dynamic Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 216, CourseId = 427, Name = "Greedy Algorithms", TopicDesc = "test desc" },
                new Topic { TopicId = 217, CourseId = 427, Name = "Backtracking", TopicDesc = "test desc" },
                new Topic { TopicId = 218, CourseId = 427, Name = "Branch-and-Bound", TopicDesc = "test desc" },
                new Topic { TopicId = 219, CourseId = 427, Name = "NP-completeness", TopicDesc = "test desc" },
                new Topic { TopicId = 220, CourseId = 427, Name = "Approximation Algorithms", TopicDesc = "test desc" },
                new Topic { TopicId = 221, CourseId = 427, Name = "Lower-Bound Limits", TopicDesc = "test desc" },
                // CS 428 Topics
                new Topic { TopicId = 222, CourseId = 428, Name = "Implementation of Graph Algorithms", TopicDesc = "test desc" },
                new Topic { TopicId = 223, CourseId = 428, Name = "Undirected Graph", TopicDesc = "test desc" },
                new Topic { TopicId = 224, CourseId = 428, Name = "Directed Graph", TopicDesc = "test desc" },
                new Topic { TopicId = 225, CourseId = 428, Name = "Directed Acyclic Graphs (DAGs)", TopicDesc = "test desc" },
                new Topic { TopicId = 226, CourseId = 428, Name = "Tree", TopicDesc = "test desc" },
                new Topic { TopicId = 227, CourseId = 428, Name = "Terminology", TopicDesc = "test desc" },
                new Topic { TopicId = 228, CourseId = 428, Name = "Euler-Cycle", TopicDesc = "test desc" },
                new Topic { TopicId = 229, CourseId = 428, Name = "Shortest Path", TopicDesc = "test desc" },
                new Topic { TopicId = 230, CourseId = 428, Name = "Max-Flow", TopicDesc = "test desc" },
                new Topic { TopicId = 231, CourseId = 428, Name = "Min-Cut", TopicDesc = "test desc" },
                new Topic { TopicId = 232, CourseId = 428, Name = "Bipartite Matching", TopicDesc = "test desc" },
                new Topic { TopicId = 233, CourseId = 428, Name = "Planarity", TopicDesc = "test desc" },
                new Topic { TopicId = 234, CourseId = 428, Name = "Graph Search", TopicDesc = "test desc" },
                new Topic { TopicId = 235, CourseId = 428, Name = "Bridge", TopicDesc = "test desc" },
                new Topic { TopicId = 236, CourseId = 428, Name = "Articulation Point", TopicDesc = "test desc" },
                new Topic { TopicId = 237, CourseId = 428, Name = "Connected Components", TopicDesc = "test desc" },
                new Topic { TopicId = 238, CourseId = 428, Name = "Layering Partition", TopicDesc = "test desc" },
                new Topic { TopicId = 239, CourseId = 428, Name = "Graph Drawing", TopicDesc = "test desc" },
                new Topic { TopicId = 240, CourseId = 428, Name = "Graph Isomorphism", TopicDesc = "test desc" },
                new Topic { TopicId = 241, CourseId = 428, Name = "Largest Common Subgraph", TopicDesc = "test desc" },
                new Topic { TopicId = 242, CourseId = 428, Name = "Graph Edit Distance", TopicDesc = "test desc" },
                new Topic { TopicId = 243, CourseId = 428, Name = "Colouring", TopicDesc = "test desc" },
                new Topic { TopicId = 244, CourseId = 428, Name = "Packing and Covering", TopicDesc = "test desc" },
                new Topic { TopicId = 245, CourseId = 428, Name = "Exploring Current Research Topics", TopicDesc = "test desc" },
                // CS 430 Topics
                new Topic { TopicId = 246, CourseId = 430, Name = "Cybersecurity Introduction", TopicDesc = "test desc" },
                new Topic { TopicId = 247, CourseId = 430, Name = "Security Trends", TopicDesc = "test desc" },
                new Topic { TopicId = 248, CourseId = 430, Name = "General Security Concepts", TopicDesc = "test desc" },
                new Topic { TopicId = 249, CourseId = 430, Name = "Operational and Organizational Security", TopicDesc = "test desc" },
                new Topic { TopicId = 250, CourseId = 430, Name = "Role of People in Security", TopicDesc = "test desc" },
                new Topic { TopicId = 251, CourseId = 430, Name = "Cryptography", TopicDesc = "test desc" },
                new Topic { TopicId = 252, CourseId = 430, Name = "Network Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 253, CourseId = 430, Name = "Infrastructure Security", TopicDesc = "test desc" },
                new Topic { TopicId = 254, CourseId = 430, Name = "Authentication and Remote Access", TopicDesc = "test desc" },
                new Topic { TopicId = 255, CourseId = 430, Name = "Wireless Security", TopicDesc = "test desc" },
                new Topic { TopicId = 256, CourseId = 430, Name = "Physical Security", TopicDesc = "test desc" },
                // CS 440 Topics
                new Topic { TopicId = 257, CourseId = 440, Name = "Fundamentals of Computer Graphics using OpenGL", TopicDesc = "test desc" },
                new Topic { TopicId = 258, CourseId = 440, Name = "Drawing Figures", TopicDesc = "test desc" },
                new Topic { TopicId = 259, CourseId = 440, Name = "Drawing Tools", TopicDesc = "test desc" },
                new Topic { TopicId = 260, CourseId = 440, Name = "Vector Tools", TopicDesc = "test desc" },
                new Topic { TopicId = 261, CourseId = 440, Name = "Transformations of Objects", TopicDesc = "test desc" },
                new Topic { TopicId = 262, CourseId = 440, Name = "Fractals", TopicDesc = "test desc" },
                new Topic { TopicId = 263, CourseId = 440, Name = "Tools for Faster Display", TopicDesc = "test desc" },
                // CS 445 Topics
                new Topic { TopicId = 264, CourseId = 445, Name = "Jupyter Notebook", TopicDesc = "test desc" },
                new Topic { TopicId = 265, CourseId = 445, Name = "Data Abstraction", TopicDesc = "test desc" },
                new Topic { TopicId = 266, CourseId = 445, Name = "Data Representation", TopicDesc = "test desc" },
                new Topic { TopicId = 267, CourseId = 445, Name = "Effective Design of Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 268, CourseId = 445, Name = "Static Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 269, CourseId = 445, Name = "Interactive Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 270, CourseId = 445, Name = "Multi-Dimensional Displays", TopicDesc = "test desc" },
                new Topic { TopicId = 271, CourseId = 445, Name = "Marks and Channels", TopicDesc = "test desc" },
                new Topic { TopicId = 272, CourseId = 445, Name = "Seaborn", TopicDesc = "test desc" },
                new Topic { TopicId = 273, CourseId = 445, Name = "Rules of Thumb", TopicDesc = "test desc" },
                new Topic { TopicId = 274, CourseId = 445, Name = "Colors", TopicDesc = "test desc" },
                new Topic { TopicId = 275, CourseId = 445, Name = "3D Graphics", TopicDesc = "test desc" },
                new Topic { TopicId = 276, CourseId = 445, Name = "Spatial Fields", TopicDesc = "test desc" },
                new Topic { TopicId = 277, CourseId = 445, Name = "Map Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 278, CourseId = 445, Name = "Arrange Network", TopicDesc = "test desc" },
                new Topic { TopicId = 279, CourseId = 445, Name = "Trees", TopicDesc = "test desc" },
                new Topic { TopicId = 280, CourseId = 445, Name = "Principal Component Analysis (PCA) using Python", TopicDesc = "test desc" },
                // CS 446 Topics
                new Topic { TopicId = 281, CourseId = 446, Name = "History of User Interface (UI)", TopicDesc = "test desc" },
                new Topic { TopicId = 282, CourseId = 446, Name = "Usability, Learnability, Efficiency", TopicDesc = "test desc" },
                new Topic { TopicId = 283, CourseId = 446, Name = "User-Centered Design", TopicDesc = "test desc" },
                new Topic { TopicId = 284, CourseId = 446, Name = "Safety, Errors and User Control", TopicDesc = "test desc" },
                new Topic { TopicId = 285, CourseId = 446, Name = "Prototyping", TopicDesc = "test desc" },
                new Topic { TopicId = 286, CourseId = 446, Name = "Usability Testing", TopicDesc = "test desc" },
                new Topic { TopicId = 287, CourseId = 446, Name = "UI Software Architecture", TopicDesc = "test desc" },
                new Topic { TopicId = 288, CourseId = 446, Name = "Output", TopicDesc = "test desc" },
                new Topic { TopicId = 289, CourseId = 446, Name = "Input", TopicDesc = "test desc" },
                new Topic { TopicId = 290, CourseId = 446, Name = "Graphics Design", TopicDesc = "test desc" },
                new Topic { TopicId = 291, CourseId = 446, Name = "Layout, Color, Typography", TopicDesc = "test desc" },
                new Topic { TopicId = 292, CourseId = 446, Name = "Heuristic Evaluation", TopicDesc = "test desc" },
                new Topic { TopicId = 293, CourseId = 446, Name = "Accessibility", TopicDesc = "test desc" },
                new Topic { TopicId = 294, CourseId = 446, Name = "Internationalization", TopicDesc = "test desc" },
                // CS 450 Topics
                new Topic { TopicId = 295, CourseId = 450, Name = "Networking Foundation", TopicDesc = "test desc" },
                new Topic { TopicId = 296, CourseId = 450, Name = "Direct Links", TopicDesc = "test desc" },
                new Topic { TopicId = 297, CourseId = 450, Name = "Internetworking", TopicDesc = "test desc" },
                new Topic { TopicId = 298, CourseId = 450, Name = "Advanced Internetworking", TopicDesc = "test desc" },
                new Topic { TopicId = 299, CourseId = 450, Name = "End-to-End Protocols", TopicDesc = "test desc" },
                new Topic { TopicId = 300, CourseId = 450, Name = "Congestion Control", TopicDesc = "test desc" },
                new Topic { TopicId = 301, CourseId = 450, Name = "Network Security", TopicDesc = "test desc" },
                // CS 452 Topics
                new Topic { TopicId = 302, CourseId = 452, Name = "Reconnaissance", TopicDesc = "test desc" },
                new Topic { TopicId = 303, CourseId = 452, Name = "Footprinting Enumeration", TopicDesc = "test desc" },
                new Topic { TopicId = 304, CourseId = 452, Name = "Vulnerability Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 305, CourseId = 452, Name = "Exploitation", TopicDesc = "test desc" },
                new Topic { TopicId = 306, CourseId = 452, Name = "Gaining Access", TopicDesc = "test desc" },
                new Topic { TopicId = 307, CourseId = 452, Name = "Privilege Escalation", TopicDesc = "test desc" },
                new Topic { TopicId = 308, CourseId = 452, Name = "Post-Exploitation", TopicDesc = "test desc" },
                new Topic { TopicId = 309, CourseId = 452, Name = "Persistence and Clearing Tracks", TopicDesc = "test desc" },
                new Topic { TopicId = 310, CourseId = 452, Name = "Web Interception, Analysis and Exploitation", TopicDesc = "test desc" },
                new Topic { TopicId = 311, CourseId = 452, Name = "Burp Suite", TopicDesc = "test desc" },
                new Topic { TopicId = 312, CourseId = 452, Name = "SQL Injection", TopicDesc = "test desc" },
                new Topic { TopicId = 313, CourseId = 452, Name = "Cross-Site Scripting (XSS) and Cross-Site Request Forgery (CSRF)", TopicDesc = "test desc" },
                new Topic { TopicId = 314, CourseId = 452, Name = "Malware Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 315, CourseId = 452, Name = "Wireless, Cloud and IoT Attack", TopicDesc = "test desc" },
                new Topic { TopicId = 316, CourseId = 452, Name = "AI-Powered Ethical Hacking", TopicDesc = "test desc" },
                new Topic { TopicId = 317, CourseId = 452, Name = "Reporting and Documentation", TopicDesc = "test desc" },
                // CS 456 Topics
                new Topic { TopicId = 318, CourseId = 456, Name = "Big Data Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 319, CourseId = 456, Name = "Types of Attributes", TopicDesc = "test desc" },
                new Topic { TopicId = 320, CourseId = 456, Name = "Properties of Attribute Values", TopicDesc = "test desc" },
                new Topic { TopicId = 321, CourseId = 456, Name = "Types of Data", TopicDesc = "test desc" },
                new Topic { TopicId = 322, CourseId = 456, Name = "Data Quality", TopicDesc = "test desc" },
                new Topic { TopicId = 323, CourseId = 456, Name = "Sampling", TopicDesc = "test desc" },
                new Topic { TopicId = 324, CourseId = 456, Name = "Data Normalization", TopicDesc = "test desc" },
                new Topic { TopicId = 325, CourseId = 456, Name = "Data Cleaning", TopicDesc = "test desc" },
                new Topic { TopicId = 326, CourseId = 456, Name = "Similarity Measures", TopicDesc = "test desc" },
                new Topic { TopicId = 327, CourseId = 456, Name = "Feature Selection", TopicDesc = "test desc" },
                new Topic { TopicId = 328, CourseId = 456, Name = "Instance Selection", TopicDesc = "test desc" },
                new Topic { TopicId = 329, CourseId = 456, Name = "Data Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 330, CourseId = 456, Name = "Data Collection", TopicDesc = "test desc" },
                new Topic { TopicId = 331, CourseId = 456, Name = "Apriori Algorithm", TopicDesc = "test desc" },
                new Topic { TopicId = 332, CourseId = 456, Name = "Association Pattern Evaluation", TopicDesc = "test desc" },
                new Topic { TopicId = 333, CourseId = 456, Name = "Clustering", TopicDesc = "test desc" },
                new Topic { TopicId = 334, CourseId = 456, Name = "K-Nearest Neighbor Algorithm", TopicDesc = "test desc" },
                new Topic { TopicId = 335, CourseId = 456, Name = "K-Mean Algorithm", TopicDesc = "test desc" },
                new Topic { TopicId = 336, CourseId = 456, Name = "Cross Evaluation", TopicDesc = "test desc" },
                new Topic { TopicId = 337, CourseId = 456, Name = "F1-Score", TopicDesc = "test desc" },
                // CS 457 Topics
                new Topic { TopicId = 338, CourseId = 457, Name = "Neural Network Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 339, CourseId = 457, Name = "Python for Machine Learning", TopicDesc = "test desc" },
                new Topic { TopicId = 340, CourseId = 457, Name = "Weka Explorer", TopicDesc = "test desc" },
                new Topic { TopicId = 341, CourseId = 457, Name = "Weka Experimenter", TopicDesc = "test desc" },
                new Topic { TopicId = 342, CourseId = 457, Name = "KnowledgeFlow", TopicDesc = "test desc" },
                new Topic { TopicId = 343, CourseId = 457, Name = "Preliminaries in Machine Learning", TopicDesc = "test desc" },
                new Topic { TopicId = 344, CourseId = 457, Name = "Notations", TopicDesc = "test desc" },
                new Topic { TopicId = 345, CourseId = 457, Name = "Perceptron", TopicDesc = "test desc" },
                new Topic { TopicId = 346, CourseId = 457, Name = "Overview of Neural Network", TopicDesc = "test desc" },
                new Topic { TopicId = 347, CourseId = 457, Name = "Perceptron Convergence Theorem", TopicDesc = "test desc" },
                new Topic { TopicId = 348, CourseId = 457, Name = "Multi-Layer Perceptron", TopicDesc = "test desc" },
                new Topic { TopicId = 349, CourseId = 457, Name = "Gradient Descent", TopicDesc = "test desc" },
                new Topic { TopicId = 350, CourseId = 457, Name = "Backpropagation", TopicDesc = "test desc" },
                new Topic { TopicId = 351, CourseId = 457, Name = "Overfitting vs Generalization", TopicDesc = "test desc" },
                new Topic { TopicId = 352, CourseId = 457, Name = "Network Design", TopicDesc = "test desc" },
                new Topic { TopicId = 353, CourseId = 457, Name = "Universal Approximation Theorem", TopicDesc = "test desc" },
                new Topic { TopicId = 354, CourseId = 457, Name = "Classification vs Regression", TopicDesc = "test desc" },
                new Topic { TopicId = 355, CourseId = 457, Name = "Time-Series Prediction", TopicDesc = "test desc" },
                new Topic { TopicId = 356, CourseId = 457, Name = "Data Preprocessing", TopicDesc = "test desc" },
                new Topic { TopicId = 357, CourseId = 457, Name = "Evolutionary Learning", TopicDesc = "test desc" },
                new Topic { TopicId = 358, CourseId = 457, Name = "Genetic Algorithms Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 359, CourseId = 457, Name = "GA Schemata Theorem", TopicDesc = "test desc" },
                new Topic { TopicId = 360, CourseId = 457, Name = "LVQ", TopicDesc = "test desc" },
                new Topic { TopicId = 361, CourseId = 457, Name = "SOM", TopicDesc = "test desc" },
                new Topic { TopicId = 362, CourseId = 457, Name = "Cluster Analysis", TopicDesc = "test desc" },
                // CS 460 Topics
                new Topic { TopicId = 363, CourseId = 460, Name = "Android Studio Fundamentals with Java", TopicDesc = "test desc" },
                new Topic { TopicId = 364, CourseId = 460, Name = "Firebase Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 365, CourseId = 460, Name = "XML", TopicDesc = "test desc" },
                new Topic { TopicId = 366, CourseId = 460, Name = "Layout Design", TopicDesc = "test desc" },
                new Topic { TopicId = 367, CourseId = 460, Name = "Design Pattern", TopicDesc = "test desc" },
                new Topic { TopicId = 368, CourseId = 460, Name = "Online Data Storage", TopicDesc = "test desc" },
                new Topic { TopicId = 369, CourseId = 460, Name = "Control Flow Diagrams", TopicDesc = "test desc" },
                new Topic { TopicId = 370, CourseId = 460, Name = "MVC Design Pattern", TopicDesc = "test desc" },
                new Topic { TopicId = 371, CourseId = 460, Name = "Data Flow Diagram (DFD)", TopicDesc = "test desc" },
                new Topic { TopicId = 372, CourseId = 460, Name = "Easy-to-Use Graphical User Interface (GUI)", TopicDesc = "test desc" },
                // CS 465 Topics
                new Topic { TopicId = 373, CourseId = 465, Name = "Introduction to Computing with Python", TopicDesc = "test desc" },
                new Topic { TopicId = 374, CourseId = 465, Name = "Symbolic Computing", TopicDesc = "test desc" },
                new Topic { TopicId = 375, CourseId = 465, Name = "Plotting and Visualization", TopicDesc = "test desc" },
                new Topic { TopicId = 376, CourseId = 465, Name = "Equation Solving", TopicDesc = "test desc" },
                new Topic { TopicId = 377, CourseId = 465, Name = "Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 378, CourseId = 465, Name = "Interpolation", TopicDesc = "test desc" },
                new Topic { TopicId = 379, CourseId = 465, Name = "Integration", TopicDesc = "test desc" },
                new Topic { TopicId = 380, CourseId = 465, Name = "Sparse Matrices and Graphs", TopicDesc = "test desc" },
                new Topic { TopicId = 381, CourseId = 465, Name = "Data Processing and Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 382, CourseId = 465, Name = "Statistical Modeling", TopicDesc = "test desc" },
                new Topic { TopicId = 383, CourseId = 465, Name = "Machine Learning", TopicDesc = "test desc" },
                new Topic { TopicId = 384, CourseId = 465, Name = "Bayesian Statistics", TopicDesc = "test desc" },
                new Topic { TopicId = 385, CourseId = 465, Name = "Signal Processing", TopicDesc = "test desc" },
                // CS 466 Topics
                new Topic { TopicId = 386, CourseId = 466, Name = "Augmented Reality Concepts", TopicDesc = "test desc" },
                new Topic { TopicId = 387, CourseId = 466, Name = "Mixed Reality", TopicDesc = "test desc" },
                new Topic { TopicId = 388, CourseId = 466, Name = "Virtual Reality", TopicDesc = "test desc" },
                new Topic { TopicId = 389, CourseId = 466, Name = "Extended Reality", TopicDesc = "test desc" },
                new Topic { TopicId = 390, CourseId = 466, Name = "Virtual Reality Programming", TopicDesc = "test desc" },
                new Topic { TopicId = 391, CourseId = 466, Name = "Analyzing Issues of Virtual Reality Technology and Their Applications", TopicDesc = "test desc" },
                new Topic { TopicId = 392, CourseId = 466, Name = "Human-Computer Interaction", TopicDesc = "test desc" },
                new Topic { TopicId = 393, CourseId = 466, Name = "Measurements in Human-Computer Interaction for Virtual Reality Systems", TopicDesc = "test desc" },
                new Topic { TopicId = 394, CourseId = 466, Name = "Exploring Researches in Virtual Reality", TopicDesc = "test desc" },
                new Topic { TopicId = 395, CourseId = 466, Name = "Designing experimental Study Structures and Experimental Procedures", TopicDesc = "test desc" },
                new Topic { TopicId = 396, CourseId = 466, Name = "Developing Virtual Reality Study", TopicDesc = "test desc" },
                // CS 467 Topics
                new Topic { TopicId = 397, CourseId = 467, Name = "Introduction to Statistics", TopicDesc = "test desc" },
                new Topic { TopicId = 398, CourseId = 467, Name = "Data Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 399, CourseId = 467, Name = "Comprehensive Overview of Statistics", TopicDesc = "test desc" },
                new Topic { TopicId = 400, CourseId = 467, Name = "The R Environment", TopicDesc = "test desc" },
                new Topic { TopicId = 401, CourseId = 467, Name = "Exploring Data with Graphs", TopicDesc = "test desc" },
                new Topic { TopicId = 402, CourseId = 467, Name = "Exploring Assumptions", TopicDesc = "test desc" },
                new Topic { TopicId = 403, CourseId = 467, Name = "Correlation", TopicDesc = "test desc" },
                new Topic { TopicId = 404, CourseId = 467, Name = "Linear Regression", TopicDesc = "test desc" },
                new Topic { TopicId = 405, CourseId = 467, Name = "Logistic Regression", TopicDesc = "test desc" },
                new Topic { TopicId = 406, CourseId = 467, Name = "Means", TopicDesc = "test desc" },
                new Topic { TopicId = 407, CourseId = 467, Name = "Covariance", TopicDesc = "test desc" },
                new Topic { TopicId = 408, CourseId = 467, Name = "Formulate Hypothesis of Generic Data", TopicDesc = "test desc" },
                // CS 470 Topics
                new Topic { TopicId = 409, CourseId = 470, Name = "Operating Systems Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 410, CourseId = 470, Name = "Overview of Contemporary Operating Systems", TopicDesc = "test desc" },
                new Topic { TopicId = 411, CourseId = 470, Name = "UNIX-based Systems Fundamentals", TopicDesc = "test desc" },
                new Topic { TopicId = 412, CourseId = 470, Name = "Processes", TopicDesc = "test desc" },
                new Topic { TopicId = 413, CourseId = 470, Name = "Threads", TopicDesc = "test desc" },
                new Topic { TopicId = 414, CourseId = 470, Name = "CPU Scheduling", TopicDesc = "test desc" },
                new Topic { TopicId = 415, CourseId = 470, Name = "Main Memory", TopicDesc = "test desc" },
                new Topic { TopicId = 416, CourseId = 470, Name = "Mass Storage Systems", TopicDesc = "test desc" },
                new Topic { TopicId = 417, CourseId = 470, Name = "File System Interfaces", TopicDesc = "test desc" },
                // CS 471 Topics
                new Topic { TopicId = 418, CourseId = 471, Name = "Overview of Optimization Problems", TopicDesc = "test desc" },
                new Topic { TopicId = 419, CourseId = 471, Name = "Discrete vs Continuous Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 420, CourseId = 471, Name = "Combinatorial Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 421, CourseId = 471, Name = "Single vs Multi-Objective Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 422, CourseId = 471, Name = "Stochastic Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 423, CourseId = 471, Name = "Least Squares", TopicDesc = "test desc" },
                new Topic { TopicId = 424, CourseId = 471, Name = "Linear Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 425, CourseId = 471, Name = "Convex Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 426, CourseId = 471, Name = "Non-Linear Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 427, CourseId = 471, Name = "Local vs Global Optimization", TopicDesc = "test desc" },
                new Topic { TopicId = 428, CourseId = 471, Name = "Local Search & Hill Climbing", TopicDesc = "test desc" },
                new Topic { TopicId = 429, CourseId = 471, Name = "Tabu Search", TopicDesc = "test desc" },
                new Topic { TopicId = 430, CourseId = 471, Name = "Simulated Annealing", TopicDesc = "test desc" },
                new Topic { TopicId = 431, CourseId = 471, Name = "Monte Carlo Methods", TopicDesc = "test desc" },
                new Topic { TopicId = 432, CourseId = 471, Name = "Genetic and Evolutionary Algorithms", TopicDesc = "test desc" },
                new Topic { TopicId = 433, CourseId = 471, Name = "Swarm Intelligence & Particle Swarm Optimization (PSO)", TopicDesc = "test desc" },
                new Topic { TopicId = 434, CourseId = 471, Name = "Artificial Bee Colony (ABC)", TopicDesc = "test desc" },
                new Topic { TopicId = 435, CourseId = 471, Name = "Firefly Algorithm (FA)", TopicDesc = "test desc" },
                new Topic { TopicId = 436, CourseId = 471, Name = "Whale Optimization & Grasshopper Algorithm", TopicDesc = "test desc" },
                new Topic { TopicId = 437, CourseId = 471, Name = "Differential Evolution (DE)", TopicDesc = "test desc" },
                // CS 473 Topics
                new Topic { TopicId = 438, CourseId = 473, Name = "Motivations for Parallel Processing", TopicDesc = "test desc" },
                new Topic { TopicId = 439, CourseId = 473, Name = "Parallel Computer Architectures", TopicDesc = "test desc" },
                new Topic { TopicId = 440, CourseId = 473, Name = "Multicore Programming with OpenMP", TopicDesc = "test desc" },
                new Topic { TopicId = 441, CourseId = 473, Name = "Massively Parallel Architectures with CUDA", TopicDesc = "test desc" },
                new Topic { TopicId = 442, CourseId = 473, Name = "Message Passing Programming with MPI", TopicDesc = "test desc" },
                new Topic { TopicId = 443, CourseId = 473, Name = "Performance Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 444, CourseId = 473, Name = "Parallel Backtracking and Branch-and-Bound", TopicDesc = "test desc" },
                new Topic { TopicId = 445, CourseId = 473, Name = "Parallel Divide and Conquer", TopicDesc = "test desc" },
                new Topic { TopicId = 446, CourseId = 473, Name = "Parallel Sorting and Searching", TopicDesc = "test desc" },
                new Topic { TopicId = 447, CourseId = 473, Name = "Parallelism in Data Mining and AI", TopicDesc = "test desc" },
                new Topic { TopicId = 448, CourseId = 473, Name = "Computational Intelligence and Scientific Computing", TopicDesc = "test desc" },
                // CS 480 Topics
                new Topic { TopicId = 449, CourseId = 480, Name = "Software Development Life Cycle (SDLC) Methodologies", TopicDesc = "test desc" },
                new Topic { TopicId = 450, CourseId = 480, Name = "Project Planning", TopicDesc = "test desc" },
                new Topic { TopicId = 451, CourseId = 480, Name = "Analysis", TopicDesc = "test desc" },
                new Topic { TopicId = 452, CourseId = 480, Name = "Design", TopicDesc = "test desc" },
                new Topic { TopicId = 453, CourseId = 480, Name = "Testing", TopicDesc = "test desc" },
                new Topic { TopicId = 454, CourseId = 480, Name = "Implementation", TopicDesc = "test desc" },
                // CS 481 Topics
                new Topic { TopicId = 455, CourseId = 481, Name = "Requirements Gathering", TopicDesc = "test desc" },
                new Topic { TopicId = 456, CourseId = 481, Name = "Designing", TopicDesc = "test desc" },
                new Topic { TopicId = 457, CourseId = 481, Name = "Modeling", TopicDesc = "test desc" },
                new Topic { TopicId = 458, CourseId = 481, Name = "Implementation", TopicDesc = "test desc" },
                new Topic { TopicId = 459, CourseId = 481, Name = "Software Testing", TopicDesc = "test desc" },
                new Topic { TopicId = 460, CourseId = 481, Name = "Presentation", TopicDesc = "test desc" },
                // CS 489 Topics
                new Topic { TopicId = 461, CourseId = 489, Name = "Ethics Case of Trending Technologies", TopicDesc = "test desc" },
                new Topic { TopicId = 462, CourseId = 489, Name = "Professional Responsibility", TopicDesc = "test desc" },
                new Topic { TopicId = 463, CourseId = 489, Name = "Computer Technology, Culture and Society", TopicDesc = "test desc" },
                new Topic { TopicId = 464, CourseId = 489, Name = "Computer Crime", TopicDesc = "test desc" },
                new Topic { TopicId = 465, CourseId = 489, Name = "Software Piracy", TopicDesc = "test desc" },
                new Topic { TopicId = 466, CourseId = 489, Name = "Patents and Copyrights", TopicDesc = "test desc" },
                new Topic { TopicId = 467, CourseId = 489, Name = "Global Implications", TopicDesc = "test desc" },
                new Topic { TopicId = 468, CourseId = 489, Name = "Internet Security", TopicDesc = "test desc" }
            );
        }
    }
}
