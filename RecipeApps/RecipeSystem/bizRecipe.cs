using CPUFramework;

namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe()
        {

        }
        private int _recipeid = 0;
        private int _cuisined = 0;
        private int _userid = 0;
        private string _recipename = "";
        private string _recipestatus = "";
        private int _calories = 0;
        private DateTime? _datedrafted;
        private DateTime? _datepublished;
        private DateTime? _datearchived;
        private DateTime? _datedraftedasdateonly;

        public int RecipeId
        {
            get => _recipeid;
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int CuisineId
        {
            get => _cuisined;
            set
            {
                if (_cuisined != value)
                {
                    _cuisined = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int UserId
        {
            get => _userid;
            set
            {
                if (_userid != value)
                {
                    _userid = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeName
        {
            get => _recipename;
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }
        public string RecipeStatus
        {
            get => _recipestatus;
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }
        public int Calories
        {
            get => _calories;
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateDrafted
        {
            get => _datedrafted;
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DatePublished
        {
            get => _datepublished;
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateArchived
        {
            get => _datearchived;
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }
        public DateTime? DateDraftedAsDateOnly
        {
            get => _datedraftedasdateonly;
            set
            {
                if (_datedraftedasdateonly != value)
                {
                    _datedraftedasdateonly = value;
                    InvokePropertyChanged();
                }
            }
        }


    }
}
