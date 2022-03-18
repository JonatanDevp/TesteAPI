namespace TesteAPI.Model
{
    public abstract class BaseValidacao
    {
        public bool HasNumber { get; set; }
        public bool HasUpperChar { get; set; }
        public bool HasLower { get; set; }
        public bool HasMinimum9Chars { get; set; }
        public bool HasSpecial { get; set; }
    }
}

