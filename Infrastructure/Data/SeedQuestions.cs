using Core.Domain.Models;

namespace Infrastructure.Data;

public static class SeedQuestions
{
    public static IEnumerable<Question> Execute()
    {
        return new Question[]
        {
            new Question
            {
                Id = 1,
                QuestionText =
                    "___ divides an an input into sorted and unsorted regions, then iteratively moves elements to the sorted region.",
                AnswerOptions = new string[] { "heapsort", "mergesort", "bubble-sort", "linear-sort" },
                CorrectAnswer = "heapsort", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 2,
                QuestionText =
                    "___ divides an array into smaller, sorted arrays, then combines these arrays into a final sorted list.",
                AnswerOptions = new string[] { "quicksort", "heapsort", "quantum-sort", "mergesort" },
                CorrectAnswer = "mergesort", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 3,
                QuestionText =
                    "___ is a pillar of object-oriented programming which states that variables and methods are grouped inside their associated object, in order to prevent the client from directly accessing the data of the object.",
                AnswerOptions = new string[] { "polymorphism", "soap", "encapsulation", "rest" },
                CorrectAnswer = "encapsulation", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 4,
                QuestionText =
                    "___ is a sorting method that selects a pivot-position in an array, and arranges all elements either to the left or right of the pivot depending on their values.",
                AnswerOptions = new string[] { "mergesort", "quicksort", "heapsort", "treesort" },
                CorrectAnswer = "quicksort", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 5,
                QuestionText =
                    "___ is one of the pillars of object-oriented programming, defined as the ability to always present the same interface, despite different underlying forms or data types.",
                AnswerOptions = new string[] { "polymorphism", "encapsulation", "abstraction", "inheritance" },
                CorrectAnswer = "polymorphism", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 6,
                QuestionText =
                    "___ search first explores one node adjacent to the root and a path though its children, then explores other adjacent nodes.",
                AnswerOptions = new string[] { "breadth-first", "mst", "depth-first", "linear" },
                CorrectAnswer = "depth-first", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 7,
                QuestionText =
                    "___ time is a concept which considers the time-complexity of an algorithm at both its worst-case runtime and its normal runtime.",
                AnswerOptions = new string[] { "elliptical", "asymptotic", "amortized", "acyclic" },
                CorrectAnswer = "amortized", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 8,
                QuestionText =
                    "___ works iteratively on an array to place items into buckets according to their least significant digit. this process is repeated through each digit of each item until a pass has been made through all digits.",
                AnswerOptions = new string[] { "bubble-sort", "radix-sort", "heapsort", "stacksort" },
                CorrectAnswer = "radix-sort", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 9,
                QuestionText =
                    "a ___ database is organized into a set of related tables which can be combined using keys.",
                AnswerOptions = new string[] { "relational", "complex", "hierarchical", "soap" },
                CorrectAnswer = "relational", CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 10, QuestionText = "a ___ database organizes data into trees rather than tables.",
                AnswerOptions = new string[] { "multi-way", "relational", "hierarchical", "tree-based" },
                CorrectAnswer = "hierarchical", CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 11, QuestionText = "a ___ graph contains every possible edge between its vertices.",
                AnswerOptions = new string[] { "intricate", "complex", "complete", "multiplex" },
                CorrectAnswer = "complete", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 12, QuestionText = "a ___ is a connected graph in which there are no cycles.",
                AnswerOptions = new string[] { "tree", "regular-graph", "cartograph", "parabola" },
                CorrectAnswer = "tree", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 13,
                QuestionText =
                    "a ___ is a data structure in which each value of each node is no smaller than the value of its parent.",
                AnswerOptions = new string[] { "max-heap", "red/black-tree", "min-heap", "heap" },
                CorrectAnswer = "min-heap", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 14,
                QuestionText =
                    "a ___ is a data structure that implements an associative array which can map keys to values.",
                AnswerOptions = new string[] { "cryptogram", "queue", "hash-table", "stack" },
                CorrectAnswer = "hash-table", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 15,
                QuestionText =
                    "a ___ is a last-in, first-out data structure in which element are only removed from the top.",
                AnswerOptions = new string[] { "trie", "binary tree", "stack", "heap" }, CorrectAnswer = "stack",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 16, QuestionText = "a ___ is a multi-way tree built based on a prefix of strings.",
                AnswerOptions = new string[] { "trie", "treap", "avl-tree", "b-tree" }, CorrectAnswer = "trie",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 17, QuestionText = "a ___ of a tree does not have any children.",
                AnswerOptions = new string[] { "leaf-node", "external-node", "exosphere", "vertex" },
                CorrectAnswer = "leaf-node", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 18,
                QuestionText =
                    "a ___ polynomial algorithm computes the correct solution to a problem in polynomial time, but can exhibit different behaviors for the same input.",
                AnswerOptions = new string[] { "reflexive", "polar", "non-deterministic", "non-standard" },
                CorrectAnswer = "non-deterministic", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 19,
                QuestionText =
                    "a ___ represents the power to which a base number must be raised to produce a specified value.",
                AnswerOptions = new string[] { "logarithm", "transliteration", "hypotenuse", "derivative" },
                CorrectAnswer = "logarithm", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 20, QuestionText = "a binary tree has (at-most) ___ children.",
                AnswerOptions = new string[] { "ten", "two", "four", "three" }, CorrectAnswer = "two", CategoryId = 1,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 21,
                QuestionText = "a collection of elements indexed by a key and stored sequentially is a/an ___.",
                AnswerOptions = new string[] { "array", "construct", "heap", "stack" }, CorrectAnswer = "array",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 22,
                QuestionText =
                    "a data structure in which every element contains both data and a pointer to the next element in a ___.",
                AnswerOptions = new string[] { "heap", "array", "linked-list", "treap" }, CorrectAnswer = "linked-list",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 23, QuestionText = "a double-linked list has a pointer to the next element and the ___ element.",
                AnswerOptions = new string[] { "secondary", "first", "previous", "last" }, CorrectAnswer = "previous",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 24,
                QuestionText =
                    "a heap is a partially-ordered data structure based on the key of each element, such that the highest or lowest-priority element is always stored at the ___.",
                AnswerOptions = new string[] { "branch", "source", "root", "node" }, CorrectAnswer = "root",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 25,
                QuestionText =
                    "a max-heap is a data structure in which each value of each node is ___ than the value of its parent",
                AnswerOptions = new string[] { "<=", "equal", ">=", "not-equal" }, CorrectAnswer = "<=", CategoryId = 1,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 26, QuestionText = "a path through a graph which uses every edge exactly once is a ___ path.",
                AnswerOptions = new string[] { "eulerian", "pythagorean", "parmenidean", "milesian" },
                CorrectAnswer = "eulerian", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 27,
                QuestionText =
                    "a red-black tree is a/an ___ tree where all of the keys are stored in internal nodes, and all of the leaves are null nodes.",
                AnswerOptions = new string[] { "ternary", "splay", "unbalanced", "binary-search" },
                CorrectAnswer = "binary-search", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 28, QuestionText = "a stack ___ allows for random access.",
                AnswerOptions = new string[] { "sometimes", "always", "partly", "never" }, CorrectAnswer = "never",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 29,
                QuestionText =
                    "an algorithm in which the runtime is proportional to the size of the input raised to some power is a ___ algorithm",
                AnswerOptions = new string[] { "exponential", "infinite", "polynomial", "rubic" },
                CorrectAnswer = "polynomial", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 30,
                QuestionText =
                    "an algorithm in which the total runtime is proportional to the number of items to be processed is a ___ algorithm.",
                AnswerOptions = new string[] { "controlled", "linear", "python", "mathematical" },
                CorrectAnswer = "linear", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 31, QuestionText = "an unordered collection of unique values is called a/an ___.",
                AnswerOptions = new string[] { "assortment", "set", "gallery", "series" }, CorrectAnswer = "set",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 32,
                QuestionText =
                    "counting-sort builds a ___ of key appearance frequencies, then iterates through an array to place the first element of each key into its sorted position.",
                AnswerOptions = new string[] { "graph", "pareto-chart", "pentogram", "histogram" },
                CorrectAnswer = "histogram", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 33, QuestionText = "given a sorted array, binary search has an ___ expected worst-case runtime.",
                AnswerOptions = new string[] { "o(n)", "o(1)", "o(log n)", "o (m * n)" }, CorrectAnswer = "o(log n)",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 34,
                QuestionText =
                    "given an array, bubble-sort compares each pair of ___ values and swaps them if they are out of order.",
                AnswerOptions = new string[] { "prime", "opposing", "equivalent", "adjacent" },
                CorrectAnswer = "adjacent", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 35, QuestionText = "How do you apply a box shadow effect to an element in CSS?",
                AnswerOptions = new string[]
                {
                    "shadow-effect: box", "box-shadow: 0px 0px 5px #000000", "element-shadow: box",
                    "shadow-box: 5px 5px #000000"
                },
                CorrectAnswer = "box-shadow: 0px 0px 5px #000000", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 36, QuestionText = "How do you center an element horizontally in CSS?",
                AnswerOptions = new string[]
                    { "text-align: center", "margin: auto", "align: center", "justify-content: center" },
                CorrectAnswer = "margin: auto", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 37, QuestionText = "How do you clone an object in JavaScript?",
                AnswerOptions = new string[]
                {
                    "const clonedObj = Object.assign({}, originalObj)", "const clonedObj = {...originalObj}",
                    "const clonedObj = originalObj.clone()", "const clonedObj = Object.create(originalObj)"
                },
                CorrectAnswer = "const clonedObj = Object.assign({}, originalObj)", CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 38, QuestionText = "How do you create a flexbox container in CSS?",
                AnswerOptions = new string[]
                    { "display: inline-block", "display: flex-container", "display: flex", "display: box" },
                CorrectAnswer = "display: flex", CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 39, QuestionText = "How do you create a new array in JavaScript?",
                AnswerOptions = new string[]
                {
                    "const myArray = () => []", "const myArray = []", "const myArray = new Array()",
                    "const myArray = Array.create()"
                },
                CorrectAnswer = "const myArray = []", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 40, QuestionText = "How does the 'this' keyword work in JavaScript?",
                AnswerOptions = new string[]
                {
                    "It refers to the current JavaScript file", "It refers to the parent element of an HTML element",
                    "It refers to the object that the function belongs to",
                    "It is a reserved keyword with no specific purpose"
                },
                CorrectAnswer = "It refers to the object that the function belongs to", CategoryId = 3,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 41,
                QuestionText =
                    "in ___ search, we first explore all vertices adjacent to the root before searching others.",
                AnswerOptions = new string[] { "breadth-first", "depth-first", "pattern", "domain" },
                CorrectAnswer = "breadth-first", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 42, QuestionText = "in a binary-search tree, the key of the root is ___ its left child.",
                AnswerOptions = new string[] { ">=", "<=", ">", "<" }, CorrectAnswer = ">=", CategoryId = 1,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 43,
                QuestionText = "in an acyclic graph it is ___ to find a path that begins and ends at the same vertex.",
                AnswerOptions = new string[] { "possible", "equivocal", "computable", "impossible" },
                CorrectAnswer = "impossible", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 44,
                QuestionText = "in the object-oriented programming paradigm, every object is an instance of a ___.",
                AnswerOptions = new string[] { "class", "set", "function", "variable" }, CorrectAnswer = "class",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 45,
                QuestionText =
                    "the inheritance pillar of object-oriented programming states that a ___ will inherit the variables and methods from its parent.",
                AnswerOptions = new string[] { "root", "cousin", "child", "sibling" }, CorrectAnswer = "child",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 46,
                QuestionText =
                    "the number of operations in a/an ___ algorithm is binded by a constant raised to the size of the input.",
                AnswerOptions = new string[] { "immense", "factorial", "triumvirate", "exponential" },
                CorrectAnswer = "exponential", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 47,
                QuestionText =
                    "the rate at which an algorithm grows, relative to the size of its input, is ___ runtime.",
                AnswerOptions = new string[] { "asymptotic", "exponential", "quadratic", "polynomial" },
                CorrectAnswer = "asymptotic", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 48, QuestionText = "time raised to the 4th power is ___ time",
                AnswerOptions = new string[] { "quartic", "quadratic", "quadrate", "o(n^4)" },
                CorrectAnswer = "quartic", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 49, QuestionText = "vertices on a graph are also known as ___.",
                AnswerOptions = new string[] { "edges", "planes", "nodes", "spans" }, CorrectAnswer = "nodes",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 50, QuestionText = "What does CSS stand for?",
                AnswerOptions = new string[]
                {
                    "Computer Style Sheets", "Cascading Style Sheets", "Creative Style Sheets", "Content Style Sheets"
                },
                CorrectAnswer = "Cascading Style Sheets", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 51, QuestionText = "What does the 'localStorage' object in JavaScript allow you to do?",
                AnswerOptions = new string[]
                {
                    "Store data in a user's web browser", "Access the browser's history", "Perform network requests",
                    "Manipulate the DOM"
                },
                CorrectAnswer = "Store data in a user's web browser", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 52, QuestionText = "What does the CSS property 'display: inline-block' do?",
                AnswerOptions = new string[]
                {
                    "It makes an element invisible on the web page", "It aligns text vertically within an element",
                    "It removes the default styling of an element",
                    "It makes an element a block-level element but allows other elements to flow around it"
                },
                CorrectAnswer = "It makes an element a block-level element but allows other elements to flow around it",
                CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 53, QuestionText = "What is a class in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The blueprint for creating objects with predefined properties and methods"
                },
                CorrectAnswer = "The blueprint for creating objects with predefined properties and methods",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 54, QuestionText = "What is a constructor in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "A special method used to create and initialize objects",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of defining a blueprint for an object"
                },
                CorrectAnswer = "A special method used to create and initialize objects", CategoryId = 5,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 55, QuestionText = "What is a database index and how does it improve query performance?",
                AnswerOptions = new string[]
                {
                    "A database index is a data structure that improves the speed of data retrieval operations",
                    "An index provides faster access to data by creating a copy of a subset of columns",
                    "An index reduces the number of disk I/O operations",
                    "An index allows for efficient searching and sorting of data"
                },
                CorrectAnswer =
                    "A database index is a data structure that improves the speed of data retrieval operations",
                CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 56, QuestionText = "What is a database transaction?",
                AnswerOptions = new string[]
                {
                    "A database transaction is a sequence of operations treated as a single logical unit of work",
                    "A transaction ensures data consistency", "A transaction can be rolled back in case of errors",
                    "A transaction guarantees the atomicity of database operations"
                },
                CorrectAnswer =
                    "A database transaction is a sequence of operations treated as a single logical unit of work",
                CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 57, QuestionText = "What is a design pattern in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It is a reusable solution to a commonly occurring problem in software design",
                    "Design patterns capture best practices",
                    "Design patterns provide a template for solving similar problems",
                    "Design patterns improve code reusability and maintainability"
                },
                CorrectAnswer = "It is a reusable solution to a commonly occurring problem in software design",
                CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 58, QuestionText = "What is a foreign key in a database?",
                AnswerOptions = new string[]
                {
                    "A foreign key is a field that references the primary key of another table",
                    "A foreign key establishes a relationship between tables",
                    "A foreign key ensures referential integrity", "A foreign key allows cascading updates and deletes"
                },
                CorrectAnswer = "A foreign key is a field that references the primary key of another table",
                CategoryId = 4, DifficultyId = 1,
            },
            new Question
            {
                Id = 59, QuestionText = "What is a static method in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It is a method that belongs to a class rather than an instance of the class",
                    "Static methods can be accessed using the class name",
                    "Static methods cannot access non-static members of a class",
                    "Static methods are commonly used for utility functions"
                },
                CorrectAnswer = "It is a method that belongs to a class rather than an instance of the class",
                CategoryId = 5, DifficultyId = 2,
            },
            new Question
            {
                Id = 60, QuestionText = "What is a stored procedure in a database?",
                AnswerOptions = new string[]
                {
                    "A stored procedure is a precompiled set of SQL statements",
                    "A stored procedure can accept parameters", "A stored procedure is stored in the database",
                    "A stored procedure enhances performance and security"
                },
                CorrectAnswer = "A stored procedure is a precompiled set of SQL statements", CategoryId = 4,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 61, QuestionText = "What is a transaction in a database?",
                AnswerOptions = new string[]
                {
                    "A transaction is a logical unit of work that consists of multiple database operations",
                    "A transaction ensures data consistency and integrity",
                    "A transaction can be rolled back in case of errors",
                    "A transaction guarantees the atomicity of database operations"
                },
                CorrectAnswer = "A transaction is a logical unit of work that consists of multiple database operations",
                CategoryId = 4, DifficultyId = 1,
            },
            new Question
            {
                Id = 62, QuestionText = "What is abstraction in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of simplifying complex systems by breaking them down into smaller, more manageable parts"
                },
                CorrectAnswer =
                    "The process of simplifying complex systems by breaking them down into smaller, more manageable parts",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 63, QuestionText = "What is an object in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "An instance of a class that encapsulates data and behaviors",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of defining a blueprint for an object"
                },
                CorrectAnswer = "An instance of a class that encapsulates data and behaviors", CategoryId = 5,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 64, QuestionText = "What is database denormalization and when would you use it?",
                AnswerOptions = new string[]
                {
                    "Database denormalization is the process of intentionally introducing redundancy for performance optimization",
                    "Denormalization improves read performance by reducing the number of joins",
                    "Denormalization should be used cautiously to maintain data consistency",
                    "Denormalization is suitable for read-heavy applications"
                },
                CorrectAnswer =
                    "Database denormalization is the process of intentionally introducing redundancy for performance optimization",
                CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 65, QuestionText = "What is database normalization?",
                AnswerOptions = new string[]
                {
                    "Database normalization is the process of organizing data to reduce redundancy",
                    "Database normalization eliminates data anomalies", "Database normalization ensures data integrity",
                    "Database normalization follows a set of rules called normal forms"
                },
                CorrectAnswer = "Database normalization is the process of organizing data to reduce redundancy",
                CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 66, QuestionText = "What is encapsulation in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of defining a blueprint for an object"
                },
                CorrectAnswer = "A way to hide the internal details of an object and expose only necessary information",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 67, QuestionText = "What is inheritance in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of acquiring properties and behaviors from a parent class"
                },
                CorrectAnswer = "The process of acquiring properties and behaviors from a parent class", CategoryId = 5,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 68, QuestionText = "What is method overloading in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of defining multiple methods with the same name but different parameters"
                },
                CorrectAnswer = "The process of defining multiple methods with the same name but different parameters",
                CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 69, QuestionText = "What is method overriding in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It is the process of providing a different implementation of a method in a subclass that already exists in its parent class",
                    "It allows a subclass to provide a specific implementation of a method",
                    "Method overriding occurs when a subclass has a method with the same name and signature as its parent class"
                },
                CorrectAnswer =
                    "It is the process of providing a different implementation of a method in a subclass that already exists in its parent class",
                CategoryId = 5, DifficultyId = 2,
            },
            new Question
            {
                Id = 70, QuestionText = "What is polymorphism in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A process of combining multiple objects into a single entity",
                    "The ability of an object to take on many forms",
                    "A way to hide the internal details of an object and expose only necessary information",
                    "The process of defining a blueprint for an object"
                },
                CorrectAnswer = "The ability of an object to take on many forms", CategoryId = 5, DifficultyId = 1,
            },
            new Question
            {
                Id = 71, QuestionText = "What is recursion in programming?",
                AnswerOptions = new string[]
                {
                    "Recursion is a process in which a function calls itself",
                    "Recursion allows solving complex problems by breaking them into smaller subproblems",
                    "Recursion uses a base case to terminate the recursive calls",
                    "Recursion can be implemented using loops or function calls"
                },
                CorrectAnswer = "Recursion is a process in which a function calls itself", CategoryId = 1,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 72, QuestionText = "What is the ACID property in database transactions?",
                AnswerOptions = new string[]
                {
                    "ACID stands for Atomicity, Consistency, Isolation, and Durability",
                    "ACID properties ensure data reliability", "ACID properties maintain data integrity",
                    "ACID properties guarantee the success or failure of a transaction"
                },
                CorrectAnswer = "ACID stands for Atomicity, Consistency, Isolation, and Durability", CategoryId = 4,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 73, QuestionText = "What is the binary representation of the decimal number 10?",
                AnswerOptions = new string[] { "1010", "1000", "1100", "1110" }, CorrectAnswer = "1010", CategoryId = 1,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 74, QuestionText = "What is the Composite design pattern in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It allows you to compose objects into tree structures",
                    "Composite design pattern treats both the composition and individual objects uniformly",
                    "Composite design pattern simplifies client code",
                    "Composite design pattern supports hierarchical structures"
                },
                CorrectAnswer = "It allows you to compose objects into tree structures", CategoryId = 5,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 75, QuestionText = "What is the correct syntax to create a CSS class selector?",
                AnswerOptions = new string[] { ".classname", "#classname", "<classname>", "@classname" },
                CorrectAnswer = ".classname", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 76, QuestionText = "What is the correct way to comment out code in JavaScript?",
                AnswerOptions = new string[]
                {
                    "/* This is a comment */", "// This is a comment //", "<!-- This is a comment -->",
                    "# This is a comment #"
                },
                CorrectAnswer = "/* This is a comment */", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 77,
                QuestionText = "What is the correct way to include an external JavaScript file in an HTML document?",
                AnswerOptions = new string[]
                {
                    "<script>src='script.js'</script>", "<script href='script.js'></script>",
                    "<script file='script.js'></script>", "<script link='script.js'></script>"
                },
                CorrectAnswer = "<script>src='script.js'</script>", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 78, QuestionText = "What is the Dependency Inversion Principle in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It suggests that high-level modules should not depend on low-level modules",
                    "Dependency Inversion Principle promotes loose coupling",
                    "Dependency Inversion Principle introduces abstraction and interfaces",
                    "Dependency Inversion Principle allows for easier unit testing"
                },
                CorrectAnswer = "It suggests that high-level modules should not depend on low-level modules",
                CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 79, QuestionText = "What is the difference between '==' and '===' in JavaScript?",
                AnswerOptions = new string[]
                {
                    "Both operators perform strict equality checks",
                    "'==' performs type coercion, while '===' does not",
                    "'==' performs deep object comparison, while '===' does not",
                    "Both operators perform loose equality checks"
                },
                CorrectAnswer = "==' performs type coercion, while '===' does not", CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 80, QuestionText = "What is the difference between 'margin' and 'padding' in CSS?",
                AnswerOptions = new string[]
                {
                    "Margin' defines the space outside an element, while 'padding' defines the space inside an element",
                    "'Margin' and 'padding' are interchangeable terms in CSS",
                    "'Margin' and 'padding' both define the space outside an element",
                    "'Margin' and 'padding' have no effect on the layout"
                },
                CorrectAnswer =
                    "Margin' defines the space outside an element, while 'padding' defines the space inside an element",
                CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 81,
                QuestionText = "What is the difference between a back-end developer and a front-end developer?",
                AnswerOptions = new string[]
                {
                    "A back-end developer focuses on server-side development and data management",
                    "A front-end developer focuses on client-side development and user interfaces",
                    "Back-end developers work with databases, server-side languages, and APIs",
                    "Front-end developers work with HTML, CSS, and JavaScript to create interactive user experiences"
                },
                CorrectAnswer = "A back-end developer focuses on server-side development and data management",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 82, QuestionText = "What is the difference between a binary tree and a binary search tree (BST)?",
                AnswerOptions = new string[]
                {
                    "A binary tree can have any value in each node",
                    "A binary search tree follows the property that the left child is smaller than the parent, and the right child is greater",
                    "A binary tree may or may not be sorted",
                    "A binary search tree provides efficient searching, insertion, and deletion operations"
                },
                CorrectAnswer =
                    "A binary search tree follows the property that the left child is smaller than the parent, and the right child is greater",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 83,
                QuestionText =
                    "What is the difference between a breadth-first search (BFS) and a depth-first search (DFS)?",
                AnswerOptions = new string[]
                {
                    "BFS explores all vertices at the same level before moving to the next level",
                    "DFS explores vertices as far as possible before backtracking", "BFS uses a queue for traversal",
                    "DFS uses a stack or recursion for traversal"
                },
                CorrectAnswer = "BFS explores all vertices at the same level before moving to the next level",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 84,
                QuestionText = "What is the difference between a clustered and a non-clustered index in a database?",
                AnswerOptions = new string[]
                {
                    "A clustered index determines the physical order of data in a table",
                    "A non-clustered index is a separate structure that points to the data",
                    "A table can have only one clustered index", "A table can have multiple non-clustered indexes"
                },
                CorrectAnswer = "A clustered index determines the physical order of data in a table", CategoryId = 4,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 85, QuestionText = "What is the difference between a compiler and an interpreter?",
                AnswerOptions = new string[]
                {
                    "A compiler translates the entire source code into machine code before execution",
                    "An interpreter translates and executes the source code line by line",
                    "A compiler generates an executable file", "An interpreter does not produce an executable file"
                },
                CorrectAnswer = "A compiler translates the entire source code into machine code before execution",
                CategoryId = 1, DifficultyId = 1,
            },
            new Question
            {
                Id = 86, QuestionText = "What is the difference between a database backup and a database replication?",
                AnswerOptions = new string[]
                {
                    "A database backup creates a copy of the database at a specific point in time",
                    "Database backup is used for disaster recovery and data protection",
                    "Database replication creates and maintains multiple copies of the database in real-time",
                    "Database replication improves availability and scalability"
                },
                CorrectAnswer = "A database backup creates a copy of the database at a specific point in time",
                CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 87,
                QuestionText = "What is the difference between a deadlock and a livelock in concurrent programming?",
                AnswerOptions = new string[]
                {
                    "A deadlock occurs when two or more threads are blocked indefinitely waiting for each other",
                    "A livelock occurs when two or more threads keep changing their states without making progress",
                    "Deadlocks result in a system halt",
                    "Livelocks result in threads being unable to complete their tasks",
                    "Deadlocks involve resource acquisition", "Livelocks involve resource utilization"
                },
                CorrectAnswer =
                    "A deadlock occurs when two or more threads are blocked indefinitely waiting for each other",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 88, QuestionText = "What is the difference between a function and a method in programming?",
                AnswerOptions = new string[]
                {
                    "A function is a standalone piece of code that can be called with arguments",
                    "A method is a function that is associated with an object or a class",
                    "Functions are used in procedural programming", "Methods are used in object-oriented programming"
                },
                CorrectAnswer = "A function is a standalone piece of code that can be called with arguments",
                CategoryId = 1, DifficultyId = 1,
            },
            new Question
            {
                Id = 89, QuestionText = "What is the difference between a GET request and a POST request?",
                AnswerOptions = new string[]
                {
                    "A GET request retrieves data from the server", "A POST request submits data to the server",
                    "GET requests are idempotent and can be cached",
                    "POST requests modify server-side resources and may have side effects",
                    "GET requests include parameters in the URL", "POST requests include parameters in the request body"
                },
                CorrectAnswer = "A GET request retrieves data from the server", CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 90, QuestionText = "What is the difference between a linked list and an array?",
                AnswerOptions = new string[]
                {
                    "A linked list uses nodes to store data and references to the next node",
                    "An array stores elements in contiguous memory locations", "Linked lists have dynamic size",
                    "Arrays have fixed size", "Linked lists allow efficient insertions and deletions",
                    "Arrays allow random access to elements"
                },
                CorrectAnswer = "A linked list uses nodes to store data and references to the next node",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 91,
                QuestionText = "What is the difference between a logical backup and a physical backup in a database?",
                AnswerOptions = new string[]
                {
                    "A logical backup is a backup of the logical structure and contents of a database",
                    "A physical backup is a bit-by-bit copy of the database files",
                    "Logical backup allows for selective data restoration",
                    "Physical backup is faster but requires more storage space"
                },
                CorrectAnswer = "A logical backup is a backup of the logical", CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 92,
                QuestionText =
                    "What is the difference between a monolithic architecture and a microservices architecture?",
                AnswerOptions = new string[]
                {
                    "A monolithic architecture consists of a single, self-contained application",
                    "A microservices architecture breaks the application into smaller, loosely coupled services",
                    "Monolithic architectures have centralized control and single deployment units",
                    "Microservices architectures enable independent scaling and deployment of services"
                },
                CorrectAnswer =
                    "A microservices architecture breaks the application into smaller, loosely coupled services",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 93,
                QuestionText = "What is the difference between a server-side language and a client-side language?",
                AnswerOptions = new string[]
                {
                    "A server-side language executes on the server and generates dynamic content",
                    "A client-side language executes on the client's browser and enhances user interactions",
                    "Server-side languages interact with databases and handle business logic",
                    "Client-side languages manipulate the DOM and provide interactivity on the client-side"
                },
                CorrectAnswer = "A server-side language executes on the server and generates dynamic content",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 94, QuestionText = "What is the difference between a SQL join and a SQL subquery?",
                AnswerOptions = new string[]
                {
                    "A SQL join combines rows from two or more tables based on a related column",
                    "A SQL subquery is a query nested inside another query",
                    "SQL joins retrieve data from multiple tables in a single query",
                    "SQL subqueries return data used by the main query"
                },
                CorrectAnswer = "A SQL join combines rows from two or more tables based on a related column",
                CategoryId = 4, DifficultyId = 1,
            },
            new Question
            {
                Id = 95, QuestionText = "What is the difference between a stack and a queue?",
                AnswerOptions = new string[]
                {
                    "A stack follows the Last-In-First-Out (LIFO) principle",
                    "A queue follows the First-In-First-Out (FIFO) principle",
                    "In a stack, elements are added and removed from the top",
                    "In a queue, elements are added at the rear and removed from the front"
                },
                CorrectAnswer = "A stack follows the Last-In-First-Out (LIFO) principle", CategoryId = 1,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 96,
                QuestionText =
                    "What is the difference between a static method and an instance method in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "A static method belongs to the class and can be called without creating an instance",
                    "An instance method belongs to an object and can only be called on an instance",
                    "Static methods cannot access instance variables", "Instance methods can access instance variables",
                    "Static methods are shared among all instances",
                    "Instance methods have separate copies for each instance"
                },
                CorrectAnswer = "A static method belongs to the class and can be called without creating an instance",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 97, QuestionText = "What is the difference between a thread and a process in operating systems?",
                AnswerOptions = new string[]
                {
                    "A process is an instance of a running program",
                    "A thread is a lightweight unit of execution within a process",
                    "Processes have separate memory spaces", "Threads share the same memory space",
                    "Processes require more resources than threads"
                },
                CorrectAnswer = "A thread is a lightweight unit of execution within a process", CategoryId = 1,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 98, QuestionText = "What is the difference between a transaction and a savepoint in a database?",
                AnswerOptions = new string[]
                {
                    "A transaction is a logical unit of work that can be committed or rolled back as a whole",
                    "A savepoint allows for intermediate checkpoints within a transaction",
                    "A transaction can have multiple savepoints",
                    "A savepoint allows for partial rollback within a transaction"
                },
                CorrectAnswer =
                    "A transaction is a logical unit of work that can be committed or rolled back as a whole",
                CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 99, QuestionText = "What is the difference between a variable and a constant in programming?",
                AnswerOptions = new string[]
                {
                    "A variable is a named storage location that can hold different values",
                    "A constant is a fixed value that cannot be changed",
                    "Variables can be assigned new values during program execution",
                    "Constants provide data that remains constant throughout the program"
                },
                CorrectAnswer = "A variable is a named storage location that can hold different values", CategoryId = 1,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 100,
                QuestionText =
                    "What is the difference between aggregation and composition in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "Aggregation represents a 'has-a' relationship",
                    "Composition represents a stronger 'owns-a' relationship",
                    "Aggregation allows objects to exist independently", "Composition enforces the lifetime dependency",
                    "Aggregation is a looser coupling than composition"
                },
                CorrectAnswer =
                    "Composition represents a stronger 'owns-a' relationship;Aggregation allows objects to exist independently",
                CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 101, QuestionText = "What is the difference between an INNER JOIN and an OUTER JOIN in SQL?",
                AnswerOptions = new string[]
                {
                    "An INNER JOIN returns only the matching rows from both tables",
                    "An OUTER JOIN returns all rows from one table and the matching rows from the other table",
                    "An INNER JOIN requires a match on the join condition",
                    "An OUTER JOIN can have NULL values for non-matching rows"
                },
                CorrectAnswer = "An INNER JOIN returns only the matching rows from both tables", CategoryId = 4,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 102,
                QuestionText =
                    "What is the difference between authentication and authorization in backend development?",
                AnswerOptions = new string[]
                {
                    "Authentication verifies the identity of a user or client",
                    "Authorization determines what actions a user or client can perform",
                    "Authentication involves login and credential verification",
                    "Authorization involves access control and permissions management",
                    "Authentication precedes authorization in the authentication process"
                },
                CorrectAnswer = "Authentication verifies the identity of a user or client", CategoryId = 2,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 103,
                QuestionText =
                    "What is the difference between composition and inheritance in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "Composition allows objects to be composed of other objects",
                    "Inheritance enables objects to inherit properties and behaviors",
                    "Composition creates a 'has-a' relationship", "Inheritance creates an 'is-a' relationship"
                },
                CorrectAnswer =
                    "Composition allows objects to be composed of other objects;Inheritance enables objects to inherit properties and behaviors",
                CategoryId = 5, DifficultyId = 2,
            },
            new Question
            {
                Id = 104,
                QuestionText =
                    "What is the difference between horizontal scaling and vertical scaling in backend development?",
                AnswerOptions = new string[]
                {
                    "Horizontal scaling adds more servers to distribute the load",
                    "Vertical scaling increases the resources (CPU, RAM) of a single server",
                    "Horizontal scaling improves application performance and handles increased traffic",
                    "Vertical scaling allows handling larger datasets or more complex operations on a single server"
                },
                CorrectAnswer = "Horizontal scaling adds more servers to distribute the load", CategoryId = 2,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 105,
                QuestionText = "What is the difference between SQL and NoSQL databases in terms of data modeling?",
                AnswerOptions = new string[]
                {
                    "SQL databases follow a rigid, predefined schema",
                    "NoSQL databases provide flexibility in data modeling",
                    "SQL databases use tables and relationships", "NoSQL databases use collections or documents"
                },
                CorrectAnswer = "SQL databases follow a rigid, predefined schema", CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 106,
                QuestionText = "What is the difference between SQL and NoSQL databases in terms of scalability?",
                AnswerOptions = new string[]
                {
                    "SQL databases are vertically scalable, meaning they scale by increasing the hardware resources",
                    "NoSQL databases are horizontally scalable, meaning they scale by adding more servers to the database cluster"
                },
                CorrectAnswer =
                    "SQL databases are vertically scalable, meaning they scale by increasing the hardware resources",
                CategoryId = 4, DifficultyId = 1,
            },
            new Question
            {
                Id = 107, QuestionText = "What is the difference between SQL and NoSQL databases?",
                AnswerOptions = new string[]
                {
                    "SQL databases are structured and use a predefined schema",
                    "NoSQL databases are unstructured and do not require a fixed schema",
                    "SQL databases use SQL language for querying", "NoSQL databases are horizontally scalable"
                },
                CorrectAnswer =
                    "SQL databases are structured and use a predefined schema;NoSQL databases are unstructured and do not require a fixed schema",
                CategoryId = 4, DifficultyId = 1,
            },
            new Question
            {
                Id = 108,
                QuestionText = "What is the difference between static and dynamic typing in programming languages?",
                AnswerOptions = new string[]
                {
                    "Static typing requires explicit declaration of variable types at compile-time",
                    "Dynamic typing allows variables to have different types during runtime",
                    "Static typing provides better error detection",
                    "Dynamic typing offers more flexibility and ease of use"
                },
                CorrectAnswer = "Static typing requires explicit declaration of variable types at compile-time",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 109,
                QuestionText =
                    "What is the difference between synchronous and asynchronous programming in the backend?",
                AnswerOptions = new string[]
                {
                    "Synchronous programming blocks until a task completes",
                    "Asynchronous programming allows other tasks to proceed while waiting for a task to complete",
                    "Synchronous programming simplifies control flow",
                    "Asynchronous programming uses callbacks, promises, or async/await to handle concurrency"
                },
                CorrectAnswer = "Synchronous programming blocks until a task completes", CategoryId = 2,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 110, QuestionText = "What is the difference between synchronous and asynchronous programming?",
                AnswerOptions = new string[]
                {
                    "Synchronous programming executes tasks sequentially and waits for each task to complete",
                    "Asynchronous programming allows tasks to run independently without waiting for each other",
                    "Synchronous programming has a simpler control flow",
                    "Asynchronous programming uses callbacks or promises to handle concurrency"
                },
                CorrectAnswer =
                    "Synchronous programming executes tasks sequentially and waits for each task to complete",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 111, QuestionText = "What is the Factory Method design pattern in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It defines an interface for creating objects",
                    "Factory Method design pattern delegates the responsibility of object creation",
                    "Factory Method design pattern allows subclasses to decide the concrete class",
                    "Factory Method design pattern provides flexibility in object creation"
                },
                CorrectAnswer = "It defines an interface for creating objects", CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 112, QuestionText = "What is the Liskov Substitution Principle in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It states that objects of a superclass should be replaceable with objects of its subclasses",
                    "Liskov Substitution Principle ensures behavioral compatibility",
                    "Liskov Substitution Principle preserves the correctness of the program",
                    "Liskov Substitution Principle enforces the 'is-a' relationship"
                },
                CorrectAnswer =
                    "It states that objects of a superclass should be replaceable with objects of its subclasses",
                CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 113, QuestionText = "What is the Observer design pattern in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It defines a one-to-many dependency between objects",
                    "Observer design pattern allows for event-driven programming",
                    "Observer design pattern supports loose coupling",
                    "Observer design pattern ensures consistency between dependent objects"
                },
                CorrectAnswer = "It defines a one-to-many dependency between objects", CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 114, QuestionText = "What is the Open/Closed Principle in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It states that software entities should be open for extension but closed for modification",
                    "Open/Closed Principle promotes the use of inheritance and interfaces",
                    "Open/Closed Principle helps in maintaining code stability",
                    "Open/Closed Principle supports the concept of polymorphism"
                },
                CorrectAnswer =
                    "It states that software entities should be open for extension but closed for modification",
                CategoryId = 5, DifficultyId = 3,
            },
            new Question
            {
                Id = 115, QuestionText = "What is the purpose of a B-tree in database systems?",
                AnswerOptions = new string[]
                {
                    "A B-tree is a self-balancing search tree that maintains sorted data",
                    "A B-tree provides efficient search, insertion, and deletion operations",
                    "A B-tree is commonly used for indexing in databases",
                    "A B-tree allows for efficient range queries and sequential access"
                },
                CorrectAnswer = "A B-tree is a self-balancing search tree that maintains sorted data", CategoryId = 1,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 116, QuestionText = "What is the purpose of a database in backend development?",
                AnswerOptions = new string[]
                {
                    "A database stores and manages structured data for the application",
                    "A database provides efficient data retrieval and storage",
                    "A database ensures data integrity through validation and constraints",
                    "A database supports querying and manipulation of data"
                },
                CorrectAnswer = "A database stores and manages structured data for the application", CategoryId = 2,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 117, QuestionText = "What is the purpose of a database migration in backend development?",
                AnswerOptions = new string[]
                {
                    "Database migration is the process of applying changes to a database schema",
                    "Database migration allows for seamless updates and modifications to the database structure",
                    "Database migration tracks and manages changes to database versions",
                    "Database migration ensures data consistency and integrity during schema changes"
                },
                CorrectAnswer = "Database migration is the process of applying changes to a database schema",
                CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 118, QuestionText = "What is the purpose of a database trigger and when would you use it?",
                AnswerOptions = new string[]
                {
                    "A database trigger is a stored procedure that automatically executes in response to specific database events",
                    "A trigger can be used to enforce complex business rules",
                    "A trigger can maintain data integrity by validating changes",
                    "A trigger can be used to log or audit specific database actions"
                },
                CorrectAnswer =
                    "A database trigger is a stored procedure that automatically executes in response to specific database events",
                CategoryId = 4, DifficultyId = 3,
            },
            new Question
            {
                Id = 119, QuestionText = "What is the purpose of a database view and when would you use it?",
                AnswerOptions = new string[]
                {
                    "A database view is a virtual table derived from the result of a query",
                    "A view provides an additional layer of abstraction", "A view simplifies complex queries",
                    "A view can be used to restrict access to certain columns or rows"
                },
                CorrectAnswer = "A database view is a virtual table derived from the result of a query", CategoryId = 4,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 120, QuestionText = "What is the purpose of a hash table in computer science?",
                AnswerOptions = new string[]
                {
                    "A hash table is a data structure that allows efficient data retrieval and storage",
                    "A hash table uses a hash function to map keys to array indices",
                    "A hash table provides constant time complexity for insertions and lookups",
                    "A hash table handles collisions using techniques like chaining or open addressing"
                },
                CorrectAnswer = "A hash table is a data structure that allows efficient data retrieval and storage",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 121, QuestionText = "What is the purpose of a load-balancer?",
                AnswerOptions = new string[]
                {
                    "A load balancer distributes incoming network traffic across multiple servers",
                    "A load balancer improves application scalability and availability",
                    "A load balancer ensures efficient resource utilization and prevents overloading of individual servers",
                    "A load balancer can be implemented using hardware or software-based solutions"
                },
                CorrectAnswer = "A load balancer distributes incoming network traffic across multiple servers",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 122, QuestionText = "What is the purpose of a primary key in a database?",
                AnswerOptions = new string[]
                {
                    "A primary key uniquely identifies each record in a table",
                    "A primary key enforces data integrity and uniqueness",
                    "A primary key provides a fast way to search for records",
                    "A primary key is used to establish relationships between tables"
                },
                CorrectAnswer = "A primary key uniquely identifies each record in a table", CategoryId = 4,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 123, QuestionText = "What is the purpose of a RESTful API in backend development?",
                AnswerOptions = new string[]
                {
                    "A RESTful API provides a standardized way for clients to communicate with a server",
                    "A RESTful API enables the creation, retrieval, update, and deletion of resources",
                    "A RESTful API follows the principles of statelessness and uniform resource access",
                    "A RESTful API uses HTTP methods for different operations"
                },
                CorrectAnswer = "A RESTful API provides a standardized way for clients to communicate with a server",
                CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 124, QuestionText = "What is the purpose of a session in backend development?",
                AnswerOptions = new string[]
                {
                    "A session allows the server to maintain stateful information about a client",
                    "A session tracks user interactions and stores temporary data",
                    "A session enables personalized user experiences and authentication",
                    "A session ensures secure communication between the client and the server"
                },
                CorrectAnswer = "A session allows the server to maintain stateful information about a client",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 125, QuestionText = "What is the purpose of a SQL view in a database?",
                AnswerOptions = new string[]
                {
                    "A SQL view is a virtual table derived from the result of a query",
                    "A SQL view simplifies complex queries", "A SQL view provides an additional layer of security",
                    "A SQL view abstracts the underlying data structure"
                },
                CorrectAnswer = "A SQL view is a virtual table derived from the result of a query", CategoryId = 4,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 126, QuestionText = "What is the purpose of a virtual memory in operating systems?",
                AnswerOptions = new string[]
                {
                    "Virtual memory provides an abstraction of physical memory for programs",
                    "Virtual memory allows efficient utilization of limited physical memory",
                    "Virtual memory enables the execution of larger programs than available physical memory",
                    "Virtual memory uses paging or segmentation for memory management"
                },
                CorrectAnswer = "Virtual memory provides an abstraction of physical memory for programs",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 127, QuestionText = "What is the purpose of a web server in the context of backend development?",
                AnswerOptions = new string[]
                {
                    "A web server handles client requests and serves web content",
                    "A web server processes and executes server-side code",
                    "A web server manages network communication between clients and servers",
                    "A web server stores and retrieves data from a database"
                },
                CorrectAnswer = "A web server handles client requests and serves web content", CategoryId = 2,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 128, QuestionText = "What is the purpose of an abstract class in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It serves as a blueprint for other classes", "Abstract classes cannot be instantiated",
                    "Abstract classes can have both abstract and non-abstract methods",
                    "Abstract classes can provide default implementations for some methods"
                },
                CorrectAnswer = "It serves as a blueprint for other classes", CategoryId = 5, DifficultyId = 2,
            },
            new Question
            {
                Id = 129, QuestionText = "What is the purpose of an algorithm?",
                AnswerOptions = new string[]
                {
                    "An algorithm is a step-by-step procedure for solving a problem",
                    "An algorithm defines the logic for performing a task",
                    "An algorithm can be expressed in programming languages",
                    "An algorithm provides a solution to a specific problem"
                },
                CorrectAnswer = "An algorithm is a step-by-step procedure for solving a problem", CategoryId = 1,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 130, QuestionText = "What is the purpose of an algorithmic complexity analysis?",
                AnswerOptions = new string[]
                {
                    "Algorithmic complexity analysis evaluates the efficiency of an algorithm",
                    "Algorithmic complexity analysis measures the time and space requirements of an algorithm",
                    "Algorithmic complexity analysis helps in selecting the most suitable algorithm for a specific problem",
                    "Algorithmic complexity analysis classifies algorithms based on their efficiency growth rate"
                },
                CorrectAnswer = "Algorithmic complexity analysis evaluates the efficiency of an algorithm",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 131, QuestionText = "What is the purpose of an API in backend development?",
                AnswerOptions = new string[]
                {
                    "An API (Application Programming Interface) defines how software components should interact",
                    "An API allows different systems to communicate and share data",
                    "An API provides a set of rules and protocols for building software",
                    "An API simplifies integration and promotes modularity"
                },
                CorrectAnswer =
                    "An API (Application Programming Interface) defines how software components should interact",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 132, QuestionText = "What is the purpose of an index in a database?",
                AnswerOptions = new string[]
                {
                    "An index improves the performance of database queries",
                    "An index allows for faster data retrieval", "An index provides a quick way to locate data",
                    "An index reduces the need for full-table scans"
                },
                CorrectAnswer = "An index improves the performance of database queries", CategoryId = 4,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 133, QuestionText = "What is the purpose of Big O notation in algorithm analysis?",
                AnswerOptions = new string[]
                {
                    "Big O notation describes the upper bound of the growth rate of an algorithm",
                    "Big O notation provides a measure of algorithmic efficiency",
                    "Big O notation helps compare algorithms based on their time and space complexity",
                    "Big O notation classifies algorithms into different complexity classes"
                },
                CorrectAnswer = "Big O notation describes the upper bound of the growth rate of an algorithm",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 134, QuestionText = "What is the purpose of caching in backend development?",
                AnswerOptions = new string[]
                {
                    "Caching improves application performance by storing frequently accessed data in memory",
                    "Caching reduces the load on the database by serving cached data",
                    "Caching helps in reducing network latency and improving response times",
                    "Caching can be implemented at various levels such as application-level, database-level, or CDN-level"
                },
                CorrectAnswer =
                    "Caching improves application performance by storing frequently accessed data in memory",
                CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 135, QuestionText = "What is the purpose of conditional statements in programming?",
                AnswerOptions = new string[]
                {
                    "Conditional statements allow for different code execution paths based on conditions",
                    "Conditional statements perform logical operations",
                    "Conditional statements can control program flow",
                    "Conditional statements handle decision-making in programs"
                },
                CorrectAnswer = "Conditional statements allow for different code execution paths based on conditions",
                CategoryId = 1, DifficultyId = 1,
            },
            new Question
            {
                Id = 136, QuestionText = "What is the purpose of data structures in computer science?",
                AnswerOptions = new string[]
                {
                    "Data structures organize and store data in a specific format",
                    "Data structures enable efficient data manipulation and retrieval",
                    "Data structures provide algorithms for data processing",
                    "Data structures help in solving complex problems"
                },
                CorrectAnswer = "Data structures organize and store data in a specific format", CategoryId = 1,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 137, QuestionText = "What is the purpose of database sharding in backend development?",
                AnswerOptions = new string[]
                {
                    "Database sharding horizontally partitions data across multiple databases or servers",
                    "Database sharding improves scalability by distributing data and workload",
                    "Database sharding allows handling larger datasets and higher transaction rates",
                    "Database sharding reduces the impact of a single server failure on the entire system"
                },
                CorrectAnswer = "Database sharding horizontally partitions data across multiple databases or servers",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 138, QuestionText = "What is the purpose of error handling in backend development?",
                AnswerOptions = new string[]
                {
                    "Error handling captures and manages exceptions or errors that occur during runtime",
                    "Error handling prevents application crashes and provides graceful recovery",
                    "Error handling provides feedback to users in case of failures or invalid inputs",
                    "Error handling logs errors for debugging and troubleshooting"
                },
                CorrectAnswer = "Error handling captures and manages exceptions or errors that occur during runtime",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 139, QuestionText = "What is the purpose of indexing in database systems?",
                AnswerOptions = new string[]
                {
                    "Indexing improves query performance by creating a data structure that allows quick data retrieval",
                    "Indexing reduces the number of disk I/O operations",
                    "Indexing speeds up search, filtering, and sorting operations",
                    "Indexing is used to enforce uniqueness and primary key constraints"
                },
                CorrectAnswer =
                    "Indexing improves query performance by creating a data structure that allows quick data retrieval",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 140, QuestionText = "What is the purpose of load balancing in backend development?",
                AnswerOptions = new string[]
                {
                    "Load balancing distributes incoming network traffic across multiple servers",
                    "Load balancing improves application scalability and availability",
                    "Load balancing ensures efficient resource utilization and prevents overloading of individual servers",
                    "Load balancing can be implemented using hardware or software-based solutions"
                },
                CorrectAnswer = "Load balancing distributes incoming network traffic across multiple servers",
                CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 141, QuestionText = "What is the purpose of memoization in dynamic programming?",
                AnswerOptions = new string[]
                {
                    "Memoization is a technique to store and reuse computed results to avoid redundant calculations",
                    "Memoization optimizes the time complexity of recursive algorithms",
                    "Memoization helps in solving problems with overlapping subproblems",
                    "Memoization reduces the number of function calls in recursive algorithms"
                },
                CorrectAnswer =
                    "Memoization is a technique to store and reuse computed results to avoid redundant calculations",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 142, QuestionText = "What is the purpose of memory management in computer systems?",
                AnswerOptions = new string[]
                {
                    "Memory management allocates and deallocates memory for program execution",
                    "Memory management prevents memory leaks and ensures efficient memory utilization",
                    "Memory management tracks memory usage by programs",
                    "Memory management handles virtual memory and paging"
                },
                CorrectAnswer = "Memory management allocates and deallocates memory for program execution",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 143, QuestionText = "What is the purpose of message queues in backend development?",
                AnswerOptions = new string[]
                {
                    "Message queues enable asynchronous communication between distributed systems",
                    "Message queues decouple senders and receivers of messages",
                    "Message queues provide reliable and persistent message delivery",
                    "Message queues support message buffering and load balancing"
                },
                CorrectAnswer = "Message queues enable asynchronous communication between distributed systems",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 144, QuestionText = "What is the purpose of session management in backend development?",
                AnswerOptions = new string[]
                {
                    "Session management handles the creation, tracking, and destruction of user sessions",
                    "Session management ensures secure user authentication and authorization",
                    "Session management enables the storage of session-specific data and preferences",
                    "Session management prevents session hijacking and ensures session integrity"
                },
                CorrectAnswer = "Session management handles the creation, tracking, and destruction of user sessions",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 145, QuestionText = "What is the purpose of the <head> tag in HTML?",
                AnswerOptions = new string[]
                {
                    "It defines the main content of the web page", "It contains metadata about the web page",
                    "It specifies the layout and visual appearance of the web page",
                    "It defines a section of introductory content"
                },
                CorrectAnswer = "It contains metadata about the web page", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 146, QuestionText = "What is the purpose of the COMMIT statement in a database transaction?",
                AnswerOptions = new string[]
                {
                    "The COMMIT statement saves the changes made within a transaction",
                    "The COMMIT statement makes the changes permanent",
                    "The COMMIT statement releases locks on the affected data",
                    "The COMMIT statement ends a database transaction"
                },
                CorrectAnswer = "The COMMIT statement makes the changes permanent", CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 147, QuestionText = "What is the purpose of the CSS box-sizing property?",
                AnswerOptions = new string[]
                {
                    "Determines the size of the HTML box element", "Sets the padding and margin values of an element",
                    "Controls the visibility of an element",
                    "Specifies how the total width and height of an element are calculated"
                },
                CorrectAnswer = "Specifies how the total width and height of an element are calculated", CategoryId = 3,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 148, QuestionText = "What is the purpose of the CSS float property?",
                AnswerOptions = new string[]
                {
                    "It specifies the positioning of an element relative to its normal position",
                    "It controls the transparency of an element", "It defines the font size of an element",
                    "It specifies the spacing between lines of text"
                },
                CorrectAnswer = "It specifies the positioning of an element relative to its normal position",
                CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 149, QuestionText = "What is the purpose of the CSS property 'will-change'?",
                AnswerOptions = new string[]
                {
                    "It forces the browser to re-render an element", "It specifies the order of animations",
                    "It preloads a resource for faster loading", "It applies a gradual transition to an element"
                },
                CorrectAnswer = "It forces the browser to re-render an element", CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 150, QuestionText = "What is the purpose of the CSS property 'z-index'?",
                AnswerOptions = new string[]
                {
                    "It controls the vertical position of an element", "It specifies the rotation of an element",
                    "It sets the order of overlapping elements", "It determines the size of an element"
                },
                CorrectAnswer = "It sets the order of overlapping elements", CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 151, QuestionText = "What is the purpose of the GROUP BY clause in SQL?",
                AnswerOptions = new string[]
                {
                    "The GROUP BY clause is used to group rows based on a specified column or columns",
                    "The GROUP BY clause is used in conjunction with aggregate functions",
                    "The GROUP BY clause helps in generating summary reports",
                    "The GROUP BY clause enables data analysis and aggregation"
                },
                CorrectAnswer = "The GROUP BY clause is used to group rows based on a specified column or columns",
                CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 152, QuestionText = "What is the purpose of the HAVING clause in SQL?",
                AnswerOptions = new string[]
                {
                    "The HAVING clause is used to filter grouped data based on a condition",
                    "The HAVING clause is used after the GROUP BY clause",
                    "The HAVING clause is similar to the WHERE clause",
                    "The HAVING clause applies to aggregate functions"
                },
                CorrectAnswer = "The HAVING clause is used to filter grouped data based on a condition", CategoryId = 4,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 153, QuestionText = "What is the purpose of the HTML meta tag 'viewport'?",
                AnswerOptions = new string[]
                {
                    "It defines the character encoding of the web page", "It sets the background color of the web page",
                    "It adjusts the presentation of a web page's viewport for different devices",
                    "It defines the title of the web page"
                },
                CorrectAnswer = "It adjusts the presentation of a web page's viewport for different devices",
                CategoryId = 3, DifficultyId = 3,
            },
            new Question
            {
                Id = 154, QuestionText = "What is the purpose of the JavaScript function 'addEventListener'?",
                AnswerOptions = new string[]
                {
                    "It adds a new HTML element to the web page", "It performs a mathematical calculation",
                    "It waits for an event to occur and executes a function in response",
                    "It changes the color of an element"
                },
                CorrectAnswer = "It waits for an event to occur and executes a function in response", CategoryId = 3,
                DifficultyId = 2,
            },
            new Question
            {
                Id = 155, QuestionText = "What is the purpose of the JavaScript method 'bind'?",
                AnswerOptions = new string[]
                {
                    "It creates a new array based on the elements of an existing array",
                    "It converts a string to lowercase", "It attaches a function to an event listener",
                    "It allows explicit setting of the context for a function"
                },
                CorrectAnswer = "It allows explicit setting of the context for a function", CategoryId = 3,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 156, QuestionText = "What is the purpose of the LOCK statement in a database?",
                AnswerOptions = new string[]
                {
                    "The LOCK statement is used to explicitly lock database objects",
                    "Locking ensures data integrity in a multi-user environment",
                    "The LOCK statement prevents concurrent access to the locked resource",
                    "The LOCK statement can be used to enforce serialization of transactions"
                },
                CorrectAnswer = "The LOCK statement is used to explicitly lock database objects", CategoryId = 4,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 157, QuestionText = "What is the purpose of the ORDER BY clause in SQL?",
                AnswerOptions = new string[]
                {
                    "The ORDER BY clause is used to sort the result set in ascending or descending order",
                    "The ORDER BY clause can be used with one or more columns",
                    "The ORDER BY clause is applied after the SELECT statement",
                    "The ORDER BY clause is used for data presentation"
                },
                CorrectAnswer = "The ORDER BY clause is used to sort the result set in ascending or descending order",
                CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 158, QuestionText = "What is the purpose of the SELECT statement in SQL?",
                AnswerOptions = new string[]
                {
                    "The SELECT statement is used to retrieve data from a database table",
                    "The SELECT statement allows filtering and sorting of data",
                    "The SELECT statement can perform calculations and aggregate functions",
                    "The SELECT statement supports joining multiple tables"
                },
                CorrectAnswer = "The SELECT statement is used to retrieve data from a database table", CategoryId = 4,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 159, QuestionText = "What is the purpose of the UNION operator in SQL?",
                AnswerOptions = new string[]
                {
                    "The UNION operator combines the result sets of two or more SELECT statements",
                    "The UNION operator removes duplicates from the result set",
                    "The UNION operator requires compatible column types",
                    "The UNION operator is used to merge data from multiple tables"
                },
                CorrectAnswer = "The UNION operator combines the result sets of two or more SELECT statements",
                CategoryId = 4, DifficultyId = 2,
            },
            new Question
            {
                Id = 160, QuestionText = "What is the role of a message broker in backend development?",
                AnswerOptions = new string[]
                {
                    "A message broker facilitates communication and coordination between distributed systems",
                    "A message broker ensures reliable message delivery and guarantees message ordering",
                    "A message broker decouples senders and receivers of messages",
                    "A message broker supports publish-subscribe or point-to-point messaging patterns"
                },
                CorrectAnswer =
                    "A message broker facilitates communication and coordination between distributed systems",
                CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 161, QuestionText = "What is the role of a reverse proxy in backend development?",
                AnswerOptions = new string[]
                {
                    "A reverse proxy sits between clients and servers and forwards requests to the appropriate backend server",
                    "A reverse proxy provides load balancing and improves application performance",
                    "A reverse proxy provides an additional layer of security by hiding backend server details",
                    "A reverse proxy caches content to reduce response time and server load"
                },
                CorrectAnswer =
                    "A reverse proxy sits between clients and servers and forwards requests to the appropriate backend server",
                CategoryId = 2, DifficultyId = 3,
            },
            new Question
            {
                Id = 162, QuestionText = "What is the role of a server in backend development?",
                AnswerOptions = new string[]
                {
                    "A server processes client requests and returns responses",
                    "A server hosts the application and serves web content",
                    "A server manages network communication between clients and servers",
                    "A server handles data storage and retrieval"
                },
                CorrectAnswer = "A server processes client requests and returns responses", CategoryId = 2,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 163, QuestionText = "What is the role of a web framework in backend development?",
                AnswerOptions = new string[]
                {
                    "A web framework provides a structure and tools for building web applications",
                    "A web framework abstracts common tasks and promotes code reusability",
                    "A web framework handles routing, request handling, and response generation",
                    "A web framework simplifies the development process by providing pre-defined patterns and components"
                },
                CorrectAnswer = "A web framework provides a structure and tools for building web applications",
                CategoryId = 2, DifficultyId = 1,
            },
            new Question
            {
                Id = 164, QuestionText = "What is the role of an operating system in a computer?",
                AnswerOptions = new string[]
                {
                    "An operating system manages computer hardware and software resources",
                    "An operating system provides a user interface for interacting with the computer",
                    "An operating system enables multitasking and process scheduling",
                    "An operating system ensures data security and file management"
                },
                CorrectAnswer = "An operating system manages computer hardware and software resources", CategoryId = 1,
                DifficultyId = 1,
            },
            new Question
            {
                Id = 165, QuestionText = "What is the Singleton design pattern in object-oriented programming?",
                AnswerOptions = new string[]
                {
                    "It restricts the instantiation of a class to a single object",
                    "Singleton design pattern ensures a global point of access",
                    "Singleton design pattern is used for centralized access and management",
                    "Singleton design pattern can control resource allocation"
                },
                CorrectAnswer = "It restricts the instantiation of a class to a single object", CategoryId = 5,
                DifficultyId = 3,
            },
            new Question
            {
                Id = 166,
                QuestionText =
                    "What is the time complexity of searching an element in a sorted array using binary search?",
                AnswerOptions = new string[] { "O(log n)", "O(n)", "O(1)", "O(n log n)" }, CorrectAnswer = "O(log n)",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 167, QuestionText = "What is the time complexity of the QuickSort algorithm in the worst case?",
                AnswerOptions = new string[] { "O(n^2)", "O(n log n)", "O(log n)", "O(1)" }, CorrectAnswer = "O(n^2)",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 168, QuestionText = "which are two basic operations that can be performed on a stack?",
                AnswerOptions = new string[] { "push/pop", "lift/sort", "reduce/find", "shift/unshift" },
                CorrectAnswer = "push/pop", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 169, QuestionText = "Which CSS property is used to change the text color of an element?",
                AnswerOptions = new string[] { "font-color", "color", "text-color", "text-style" },
                CorrectAnswer = "color", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 170, QuestionText = "Which CSS property is used to control the spacing between elements?",
                AnswerOptions = new string[] { "padding", "margin", "spacing", "gap" }, CorrectAnswer = "margin",
                CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 171, QuestionText = "Which HTML element is used to define a navigation menu?",
                AnswerOptions = new string[] { "<nav>", "<header>", "<menu>", "<ul>" }, CorrectAnswer = "<nav>",
                CategoryId = 3, DifficultyId = 2,
            },
            new Question
            {
                Id = 172, QuestionText = "Which HTML tag is used to create a hyperlink?",
                AnswerOptions = new string[] { "<link>", "<a>", "<href>", "<url>" }, CorrectAnswer = "<a>",
                CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 173, QuestionText = "Which HTML tag is used to define an image?",
                AnswerOptions = new string[] { "<img>", "<image>", "<picture>", "<photo>" }, CorrectAnswer = "<img>",
                CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 174, QuestionText = "which is an example of factorial runtime?",
                AnswerOptions = new string[] { "o(n!)", "o(n log n)", "o(n^2)", "o(n-1)" }, CorrectAnswer = "o(n!)",
                CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 175,
                QuestionText =
                    "which of the following is a method of problem solving which relies on functions which call themselves and a base case?",
                AnswerOptions = new string[] { "refactory", "looping", "brute-force", "recursion" },
                CorrectAnswer = "recursion", CategoryId = 1, DifficultyId = 2,
            },
            new Question
            {
                Id = 176, QuestionText = "which of the following is an example of quadratic time?",
                AnswerOptions = new string[] { "o(n!)", "o(n log n)", "o(log n)", "o(n^2)" }, CorrectAnswer = "o(n^2)",
                CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 177, QuestionText = "which of the following is not a principle of rest?",
                AnswerOptions = new string[] { "single-layer", "client-server", "cacheable", "stateless" },
                CorrectAnswer = "single-layer", CategoryId = 2, DifficultyId = 2,
            },
            new Question
            {
                Id = 178, QuestionText = "Which of the following is NOT a valid JavaScript data type?",
                AnswerOptions = new string[] { "string", "boolean", "function", "character" },
                CorrectAnswer = "character", CategoryId = 3, DifficultyId = 1,
            },
            new Question
            {
                Id = 179,
                QuestionText =
                    "which type of sort works iteratively on an array by shifting sorted values in order to insert new values?",
                AnswerOptions = new string[] { "interjection", "insertion", "interpolation", "extradition" },
                CorrectAnswer = "insertion", CategoryId = 1, DifficultyId = 3,
            },
            new Question
            {
                Id = 180,
                QuestionText =
                    "who designed an algorithm in which nodes are inserted into a priority queue based on their known distance from a source vertex?",
                AnswerOptions = new string[] { "leibniz", "dijkstra", "turing", "heidegger" },
                CorrectAnswer = "dijkstra", CategoryId = 1, DifficultyId = 3,
            },
        };
    }
}