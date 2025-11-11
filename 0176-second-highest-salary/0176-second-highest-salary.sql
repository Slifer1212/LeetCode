/* Write your T-SQL query statement below */
SELECT
    (
        SELECT Salary
        FROM Employee
        WHERE Salary IS NOT NULL
        GROUP BY Salary
        ORDER BY Salary DESC
        OFFSET 1 ROW
        FETCH NEXT 1 ROW ONLY
    ) AS SecondHighestSalary;

