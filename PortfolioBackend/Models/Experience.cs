public class Experience{
    public int Id {
        get;
        set;
    }
    public string Title{
        get;
        set;
    }
    public string Company{
        get;
        set;
    }
    public DateTime StartDate{
        get;
        set;
    }
    public DateTime? EndDate{
        get;
        set;
    }
    public string Description{
        get;
        set;
    }
    public DateTime CreatedAt{
        get;
        set;
    }DateTime.UtcNow;
    public DateTime UpdateAt{
        get;
        set;
    }=DateTime.UtcNow;
}