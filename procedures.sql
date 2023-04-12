create or replace procedure public.insert_difficulty(
    IN pk character varying,
    IN display character varying
)
    LANGUAGE plpgsql
AS '
    BEGIN
    INSERT INTO public.difficulties(
        id, display_text, created_utc, updated_utc, created_by, updated_by)
    VALUES (pk, display, timezone(''UTC'', now()), timezone(''UTC'', now()), ''initial_create'', ''initial_create'');
    COMMIT;
    END
';

create or replace procedure public.insert_category(
    IN val character varying,
    IN display character varying
)
    LANGUAGE plpgsql
AS '
    BEGIN
    INSERT INTO public.categories(
        value, display_text, created_utc, updated_utc, created_by, updated_by)
    VALUES (val, display, timezone(''UTC'', now()), timezone(''UTC'', now()), ''initial_create'', ''initial_create'');
    COMMIT;
    END
';

create or replace procedure public.insert_question(
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
        question_text, answer_options, correct_answer, category_id, difficulty_id, created_utc, updated_utc, created_by, updated_by
    )
    VALUES (
               question_val,
               answers,
               correct,
               (SELECT id from public.categories WHERE value LIKE (''%'' || category_value || ''%'') LIMIT 1),
               (SELECT id from public.difficulties WHERE id LIKE (''%'' || difficulty_value || ''%'') LIMIT 1),
               timezone(''UTC'', now()),
               timezone(''UTC'', now()),
               ''initial_create'',
               ''initial_create''
           );
    END
';

-- EXAMPLE:
--call insert_question('test question',ARRAY['answer1','answer2','answer3','answer4'],'answer3','computer_science','easy')

create or replace procedure public.insert_tag(
    IN val character varying,
    IN display character varying
)
    LANGUAGE plpgsql
AS '
    BEGIN
    INSERT INTO public.tags(
        value, display_text, created_utc, updated_utc, created_by, updated_by)
    VALUES (
               val,
               display,
               timezone(''UTC'', now()),
               timezone(''UTC'', now()),
               ''initial_create'',
               ''initial_create''
           );
    COMMIT;
    END
';