Core --> Domain model
=====================

The very core of your application.

No other libraries, other than C#-Native libraries, should be refernced here.

Your Domain model goes here. 

Here's a few of them:

* Always use auto properties.
* Properties named **Id** or *ClassName***Id** are marked as primary key.
* Navigation properties with cardinality MANY uses `ICollection<T>` as their type. Remember to instantiate collections to avoid `NullReferenceException`s

