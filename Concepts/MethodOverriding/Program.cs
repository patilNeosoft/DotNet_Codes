
using MethodOverriding;
Parent obj1 = new Parent(); 
//here i am giving reference of child to object but it is calling parent only
Parent obj2 = new Child();

//once i define parent virtual and child override then child method can be called.
obj1.Display("pooja");
obj2.Display("pooja");
