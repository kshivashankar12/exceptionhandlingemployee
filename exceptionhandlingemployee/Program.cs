using System;

public class Employee
{
    private int empNo;
    private string empName;
    private double salary;
    private int deptNo;

    public int EmpNo
    {
        get { return empNo; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("EmpNo cannot be zero.");
            }
            empNo = value;
        }
    }

    public string EmpName
    {
        get { return empName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("EmpName cannot be null or empty.");
            }
            empName = value;
        }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public int DeptNo
    {
        get { return deptNo; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("DeptNo cannot be zero.");
            }
            deptNo = value;
        }
    }

    public Employee(int empNo, string empName, double salary, int deptNo)
    {
        EmpNo = empNo;
        EmpName = empName;
        Salary = salary;
        DeptNo = deptNo;
    }

    public override string ToString()
    {
        return $"EmpNo: {EmpNo}, EmpName: {EmpName}, Salary: {Salary}, DeptNo: {DeptNo}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Employee emp = new Employee(101, "shiva", 50000, 101);
            Console.WriteLine(emp);

            // Example with invalid values
            Employee invalidEmp = new Employee(0, "", 60000, 0);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Validation Error: {ex.Message}");
        }
    }
}
