UPDATE salary
SET sex = CASE sex
    WHEN 'f' THEN 'm'
    WHEN 'm' THEN 'f'
END;

-- UPDATE salary
-- SET sex = CASE sex
--     WHEN 'f' THEN 'm'
--     ELSE 'f'
-- END;