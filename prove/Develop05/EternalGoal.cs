
public class EternalGoal : Goal
{
    public EternalGoal(string name, string des, int point, string type) : base(name, des, point, type)
    {

    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()}|{GetName()}|{GetDescription()}|{GetPoint()}";
    }


}