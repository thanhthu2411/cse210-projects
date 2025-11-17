
public class ChecklistGoal : Goal
{
    private int _timeToComplete;
    private int _bonusPoint;
    private int _timeDone;
    // private bool _isCompleted = false;

    public ChecklistGoal(int timeToComplete, int bonusPoint, string name, string des, int point, string type) : base(name, des, point, type)
    {
        _timeToComplete = timeToComplete;
        _bonusPoint = bonusPoint;
    }

    public override void DisplayGoal()
    {
        if (_isCompleted == false)
        {
            Console.WriteLine($"[ ] {_name} ({_description}) - Currently completed: {_timeDone}/{_timeToComplete}");
        }
        else
        {
            Console.WriteLine($"[X] {_name} ({_description}) - Currently completed: {_timeDone}/{_timeToComplete}");

        }
    }

    public int GetBonusPoint()
    {
        return _bonusPoint;
    }

    public int GetTimetoComplete()
    {
        return _timeToComplete;
    }

    public int GetTimeDone()
    {
        return _timeDone;
    }

        public override bool GetStatus()
    {
        return _isCompleted;
    }

    public void SetTimeDone(int time)
    {
        _timeDone = time;
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoint()}|{GetBonusPoint()}|{GetTimetoComplete()}|{GetTimeDone()}";
    }

    public override int RecordEvent()
    {
        _timeDone++;

        if (_timeDone < _timeToComplete)
        {
            return _point;
        }
        else
        {
            _isCompleted = true;
            return _point + _bonusPoint;
        }
    }
    
    public override void ResetGoal()
    {
        _timeDone = 0;
        _isCompleted = false;
    }
}