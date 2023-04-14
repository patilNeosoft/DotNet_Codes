using GetSet;

Class1 obj = new Class1("pooja","mumbai");
//using property Name.
//propert name should be start with Capital letter
obj.Name = "Pooja";
Console.WriteLine(obj.Name);
//even if original name is patil but now outside th class i can make use of get and set and 
//can change its value to pooja.

//create constructor and assign values to it.
//and that values can be printed if we use only get.
//that is called read only.
//if we use set then that values we can change only.called write only
//if we use get set then can change value and can set values called read-write property.