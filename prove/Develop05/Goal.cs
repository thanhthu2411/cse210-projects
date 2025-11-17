
using System.Xml.Linq;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _point;
    protected string _goalType;
    protected bool _isCompleted = false;

    public Goal(string name, string des, int point, string type)
    {
        _name = name;
        _description = des;
        _point = point;
        _goalType = type;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoint()
    {
        return _point;
    }
    public virtual bool GetStatus()
    {
        return false;
    }
    public abstract string SaveGoal();
    public virtual void ResetGoal()
    {
        
    }
    public virtual int RecordEvent()
    {
        return _point;
    }

}