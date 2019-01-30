using System;
using System.Collections;
using System.Collections.Generic;
using TrainingBill;

public class Horse
{
    public string Owner
    {
        get; set;
    }
    public string Name
    {
        get; set;
    }
    //public List<Expense> expense
    //{
    //    get; set;
    //}
    public string MonthlyTotal
    {
        get; set;
    }
    Database db = new Database();
    public Horse()
    {


    }

}

