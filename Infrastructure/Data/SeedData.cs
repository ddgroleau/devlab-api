using Core.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data;

public static class SeedData
{
    public static List<Difficulty> SeedDifficulties()
    {
        return new List<Difficulty>
        {
            new Difficulty { Id = 1, DisplayText = "easy" },
            new Difficulty { Id = 2, DisplayText = "medium" },
            new Difficulty { Id = 3, DisplayText = "hard" },
        };
    }

    public static List<Category> SeedCategories()
    {
        return new List<Category>
        {
            new Category { Id = 1, Value = "computer_science", DisplayText = "computer science" },
            new Category { Id = 2, Value = "backend", DisplayText = "backend" },
            new Category { Id = 3, Value = "frontend", DisplayText = "frontend" },
            new Category { Id = 4, Value = "databases", DisplayText = "databases" },
            new Category { Id = 5, Value = "object_oriented", DisplayText = "object-oriented" },
        };
    }

    public static int SeedQuestions(DatabaseFacade database)
    {
        try
        {
            string sql = @"
            call insert_question('the rate at which an algorithm grows, relative to the size of its input, is ___ runtime.',ARRAY['asymptotic','exponential','quadratic','polynomial'],'asymptotic','computer_science','medium');
            call insert_question('an algorithm in which the total runtime is proportional to the number of items to be processed is a ___ algorithm.',ARRAY['controlled','linear','python','mathematical'],'linear','computer_science','medium');
            call insert_question('a ___ represents the power to which a base number must be raised to produce a specified value.',ARRAY['logarithm','transliteration','hypotenuse','derivative'],'logarithm','computer_science','medium');
            call insert_question('which of the following is an example of quadratic time?',ARRAY['o(n!)','o(n log n)','o(log n)','o(n^2)'],'o(n^2)','computer_science','hard');
            call insert_question('an algorithm in which the runtime is proportional to the size of the input raised to some power is a ___ algorithm',ARRAY['exponential','infinite','polynomial','rubic'],'polynomial','computer_science','hard');
            call insert_question('time raised to the 4th power is ___ time',ARRAY['quartic','quadratic','quadrate','o(n^4)'],'quartic','computer_science','hard');
            call insert_question('the number of operations in a/an ___ algorithm is binded by a constant raised to the size of the input.',ARRAY['immense','factorial','triumvirate','exponential'],'exponential','computer_science','medium');
            call insert_question('given a sorted array, binary search has an ___ expected worst-case runtime.',ARRAY['o(n)','o(1)','o(log n)','o (m * n)'],'o(log n)','computer_science','medium');
            call insert_question('which is an example of factorial runtime?',ARRAY['o(n!)','o(n log n)','o(n^2)','o(n-1)'],'o(n!)','computer_science','medium');
            call insert_question('a collection of elements indexed by a key and stored sequentially is a/an ___.',ARRAY['array','construct','heap','stack'],'array','computer_science','medium');
            call insert_question('a data structure in which every element contains both data and a pointer to the next element in a ___.',ARRAY['heap','array','linked-list','treap'],'linked-list','computer_science','medium');
            call insert_question('a double-linked list has a pointer to the next element and the ___ element.',ARRAY['secondary','first','previous','last'],'previous','computer_science','medium');
            call insert_question('a ___ is a last-in, first-out data structure in which element are only removed from the top.',ARRAY['trie','binary tree','stack','heap'],'stack','computer_science','medium');
            call insert_question('which are two basic operations that can be performed on a stack?',ARRAY['push/pop','lift/sort','reduce/find','shift/unshift'],'push/pop','computer_science','medium');
            call insert_question('a stack ___ allows for random access.',ARRAY['sometimes','always','partly','never'],'never','computer_science','medium');
            call insert_question('a heap is a partially-ordered data structure based on the key of each element, such that the highest or lowest-priority element is always stored at the ___.',ARRAY['branch','source','root','node'],'root','computer_science','hard');
            call insert_question('a ___ is a data structure in which each value of each node is no smaller than the value of its parent.',ARRAY['max-heap','red/black-tree','min-heap','heap'],'min-heap','computer_science','hard');
            call insert_question('a max-heap is a data structure in which each value of each node is ___ than the value of its parent',ARRAY['<=','equal','>=','not-equal'],'<=','computer_science','medium');
            call insert_question('a ___ is a data structure that implements an associative array which can map keys to values.',ARRAY['cryptogram','queue','hash-table','stack'],'hash-table','computer_science','medium');
            call insert_question('an unordered collection of unique values is called a/an ___.',ARRAY['assortment','set','gallery','series'],'set','computer_science','medium');
            call insert_question('a ___ polynomial algorithm computes the correct solution to a problem in polynomial time, but can exhibit different behaviors for the same input.',ARRAY['reflexive','polar','non-deterministic','non-standard'],'non-deterministic','computer_science','hard');
            call insert_question('a path through a graph which uses every edge exactly once is a ___ path.',ARRAY['eulerian','pythagorean','parmenidean','milesian'],'eulerian','computer_science','hard');
            call insert_question('vertices on a graph are also known as ___.',ARRAY['edges','planes','nodes','spans'],'nodes','computer_science','hard');
            call insert_question('a ___ graph contains every possible edge between its vertices.',ARRAY['intricate','complex','complete','multiplex'],'complete','computer_science','hard');
            call insert_question('in an acyclic graph it is ___ to find a path that begins and ends at the same vertex.',ARRAY['possible','equivocal','computable','impossible'],'impossible','computer_science','hard');
            call insert_question('a ___ is a connected graph in which there are no cycles.',ARRAY['tree','regular-graph','cartograph','parabola'],'tree','computer_science','hard');
            call insert_question('a ___ of a tree does not have any children.',ARRAY['leaf-node','external-node','exosphere','vertex'],'leaf-node','computer_science','medium');
            call insert_question('a binary tree has (at-most) ___ children.',ARRAY['ten','two','four','three'],'two','computer_science','medium');
            call insert_question('in a binary-search tree, the key of the root is ___ its left child.',ARRAY['>=','<=','>','<'],'>=','computer_science','hard');
            call insert_question('a red-black tree is a/an ___ tree where all of the keys are stored in internal nodes, and all of the leaves are null nodes.',ARRAY['ternary','splay','unbalanced','binary-search'],'binary-search','computer_science','hard');
            call insert_question('a ___ is a multi-way tree built based on a prefix of strings.',ARRAY['trie','treap','avl-tree','b-tree'],'trie','computer_science','hard');
            call insert_question('in ___ search, we first explore all vertices adjacent to the root before searching others.',ARRAY['breadth-first','depth-first','pattern','domain'],'breadth-first','computer_science','hard');
            call insert_question('___ search first explores one node adjacent to the root and a path though its children, then explores other adjacent nodes.',ARRAY['breadth-first','mst','depth-first','linear'],'depth-first','computer_science','hard');
            call insert_question('who designed an algorithm in which nodes are inserted into a priority queue based on their known distance from a source vertex?',ARRAY['leibniz','dijkstra','turing','heidegger'],'dijkstra','computer_science','hard');
            call insert_question('given an array, bubble-sort compares each pair of ___ values and swaps them if they are out of order.',ARRAY['prime','opposing','equivalent','adjacent'],'adjacent','computer_science','medium');
            call insert_question('which type of sort works iteratively on an array by shifting sorted values in order to insert new values?',ARRAY['interjection','insertion','interpolation','extradition'],'insertion','computer_science','hard');
            call insert_question('___ divides an an input into sorted and unsorted regions, then iteratively moves elements to the sorted region.',ARRAY['heapsort','mergesort','bubble-sort','linear-sort'],'heapsort','computer_science','hard');
            call insert_question('___ divides an array into smaller, sorted arrays, then combines these arrays into a final sorted list.',ARRAY['quicksort','heapsort','quantum-sort','mergesort'],'mergesort','computer_science','hard');
            call insert_question('___ is a sorting method that selects a pivot-position in an array, and arranges all elements either to the left or right of the pivot depending on their values.',ARRAY['mergesort','quicksort','heapsort','treesort'],'quicksort','computer_science','hard');
            call insert_question('counting-sort builds a ___ of key appearance frequencies, then iterates through an array to place the first element of each key into its sorted position.',ARRAY['graph','pareto-chart','pentogram','histogram'],'histogram','computer_science','hard');
            call insert_question('___ works iteratively on an array to place items into buckets according to their least significant digit. this process is repeated through each digit of each item until a pass has been made through all digits.',ARRAY['bubble-sort','radix-sort','heapsort','stacksort'],'radix-sort','computer_science','hard');
            call insert_question('in the object-oriented programming paradigm, every object is an instance of a ___.',ARRAY['class','set','function','variable'],'class','object_oriented','easy');
            call insert_question('___ is a pillar of object-oriented programming which states that variables and methods are grouped inside their associated object, in order to prevent the client from directly accessing the data of the object.',ARRAY['polymorphism','soap','encapsulation','rest'],'encapsulation','computer_science','medium');
            call insert_question('in the object-oriented programming paradigm, the process of omitting unnecessary details from an object or class in order to maintain just the essential characteristics for problem solving, is called ___.',ARRAY['encapsultation','orientation','abstraction','division'],'abstraction','computer_science','medium');
            call insert_question('___ is one of the pillars of object-oriented programming, defined as the ability to always present the same interface, despite different underlying forms or data types.',ARRAY['polymorphism','encapsulation','abstraction','inheritance'],'polymorphism','computer_science','medium');
            call insert_question('the inheritance pillar of object-oriented programming states that a ___ will inherit the variables and methods from its parent.',ARRAY['root','cousin','child','sibling'],'child','object_oriented','easy');
            call insert_question('which of the following is not a principle of rest?',ARRAY['single-layer','client-server','cacheable','stateless'],'single-layer','backend','medium');
            call insert_question('a ___ database organizes data into trees rather than tables.',ARRAY['multi-way','relational','hierarchical','tree-based'],'hierarchical','databases','medium');
            call insert_question('which of the following is a method of problem solving which relies on functions which call themselves and a base case?',ARRAY['refactory','looping','brute-force','recursion'],'recursion','computer_science','medium');
            call insert_question('___ time is a concept which considers the time-complexity of an algorithm at both its worst-case runtime and its normal runtime.',ARRAY['elliptical','asymptotic','amortized','acyclic'],'amortized','computer_science','hard');
            call insert_question('a ___ database is organized into a set of related tables which can be combined using keys.',ARRAY['relational','complex','hierarchical','soap'],'relational','databases','medium');
        ";
            using IDbContextTransaction transaction = database.BeginTransaction(); 
            int rowsAffected = database.ExecuteSqlRaw(sql);
            transaction.Commit();
            return rowsAffected;
        }
        catch (Exception e)
        {
            return 0;
        }
    }

    public static int CreatePlPgSqlProcedure_InsertQuestion(DatabaseFacade database)
    {
        try
        {
            string sql = @"
            CREATE OR REPLACE PROCEDURE public.insert_question(
                IN question_val character varying,
                IN answers character varying[],
                IN correct character varying,
                IN category_value character varying,
                IN difficulty_value character varying
            )
                LANGUAGE plpgsql
            AS '
                BEGIN
                INSERT INTO public.questions(
                    question_text, answer_options, correct_answer, category_id, difficulty_id, created_utc, modified_utc, created_by, modified_by
                )
                VALUES (
                           question_val,
                           answers,
                           correct,
                           (SELECT id from public.categories WHERE value LIKE (''%'' || category_value || ''%'') LIMIT 1),
                           (SELECT id from public.difficulties WHERE display_text LIKE (''%'' || difficulty_value || ''%'') LIMIT 1),
                           timezone(''UTC'', now()),
                           timezone(''UTC'', now()),
                           ''initial_create'',
                           ''initial_create''
                       );
                END
            ';
        ";

            return database.ExecuteSqlRaw(sql);
        }
        catch (Exception e)
        {
            return 0;
        }
    }
}