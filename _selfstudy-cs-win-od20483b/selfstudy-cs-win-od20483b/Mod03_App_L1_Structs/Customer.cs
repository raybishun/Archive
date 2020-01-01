using System;

namespace Mod03_App_L1_Structs
{

    public delegate void NameChangedEventDelegate(object sender, EventArgs e);

    // struct is a value type
    struct Customer
    {
        // struct can have properties
        // properites have 2 accesseor methods (get & set)
        // properties used to protect private files in your class
        // struct CANNOT have instance property or field 'inializers'

        private string _name;
        private string _email;
        private int _id;
        private CustomerStatusEnum _status;

        // struct can have ctors
        // struct can also have overloaded ctors
        public Customer(int id, string name, string email, CustomerStatusEnum status)
        {
            _id = id;
            _name = name;
            _email = email;
            _status = status;

            Students = new string[] { "one", "two", "three" };

            NameChanged = null;
        }

        public event NameChangedEventDelegate NameChanged;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                // Validation
                _name = value;
                onNameChanged();
            }
        }

        private void onNameChanged()
        {
            if (NameChanged != null)
            {
                // if != null, means at least one object has 'subscribed' to this event (so it's valid)
                NameChanged(this, new EventArgs());
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public CustomerStatusEnum Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        // struct cannot contain explicit parameterless ctor
        // public Customer() {}

        public string[] Students { get; set; }

        public string this[int index]
        {
            get { return this.Students[index]; }
            set { this.Students[index] = value; }
        }

        // can override ToString()
        public override string ToString()
        {
            return string.Format($"{Id}\n{Name}\n{Email}\n{Status}");
        }
    }
}