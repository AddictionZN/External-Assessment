# Database Challenges


Please see the attached CSV files. These files contain a client’s employee data as well as event detail for a single day from all relevant mobile vendors for SIMs owned by those employees. Please refer to these files when answering the following questions.


## Question 1

Using the files given, design a SQL database that can store data of this nature. Send us the ERD of the proposed database in any format you prefer. Eliminate data redundancies where possible.


## Question 2

The company has decided to give each employee a company email. All current email addresses will be ported over, but the Host will change to “company”. As an example, please refer to Figure 1.

The email in Figure 1 will be updated to example@company.com. They need you to update the database to reflect this change.
Import the attached CSV employee file to SQL as a table and come up with a SQL script to update all employee email addresses in the table accordingly. 
Please note* 
*	The user must remain unchanged.
*	The domain must remain unchanged.

# Back-end Code Challenges
* Only send back the code required for your the challenges

## Question 1

You are probably familiar with social media "like" systems. People can like posts and the UI displays who likes certain posts.
Write a method that takes in a list of names and produces the format below:

```csharp
Likes(new List<string>()) => "no one likes this"
Likes(new List<string> {"Peter"}) => "Peter likes this"
Likes(new List<string> {"Jacob", "Alex"}) => "Jacob and Alex like this"
Likes(new List<string> {"Max", "John", "Mark"}) => "Max, John and Mark like this"
Likes(new List<string> {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
```

__Note__: if the amount of people who like something is 4 or more, print out the first 2 names following by how many others like it.

## Question 2
The last task is about refactoring of code. Below you are given a class that creates robots and cars, this class uses a robot service, a part service, and a car service, which can be any web services (RESTful or SOAP).

You need to refactor this class as you see fit. The goal is to make the class more maintainable. You should apply any principles or patterns you think are necessary.

Don't write out the web service classes. Assume they have an implementation and you are just consuming them.

* Bonus: what can be done to reduce tight coupling in a class?

```csharp
public class Factory
{
    private RobotService _robotService;
    private PartsService _partsService;
    private CarService _carService;
    
    public Factory(RobotService robotService, PartsService partsService)
    {
        _robotService = new RobotService();
        _partsService = new PartsService();
        _carService = new CarService();
    }

    public Robot BuildRobot(Enum RobotType)
    {
        if(RobotType == RoboticDog)
            var parts = GetRobotPartsFor(RoboticDog);
            return _robotService.BuildRobotDog(parts);
        else if(RobotType == RoboticCat)
            var parts = GetRobotPartsFor(RoboticCat);
            return _robotService.BuildRobotCat(parts);
        else if(RobotType == RoboticDrone)
            var parts = GetRobotPartsFor(RoboticDrone);
            return _robotService.BuildRobotDrone(parts);
        else if (RobotType == RoboticCar)
            var parts = GetRobotPartsFor(RoboticCar);
            return _robotService.BuildRobotCar(parts);
        else
            return null;
    }

    public Car BuildCar(Enum CarType)
    {
        if(CarType == Toyota)
            var parts = GetCarPartsFor(Toyota);
            return _carService.BuildCar(parts);
        else if(RobotType == Ford)
            var parts = GetCarPartsFor(Ford);
            return _carService.BuildCar(parts);
        else if(RobotType == Opel)
            var parts = GetCarPartsFor(Opel);
            return _carService.BuildCar(parts);
        else if (RobotType == Honda)
            var parts = GetCarPartsFor(Honda);
            return _carService.BuildCar(parts);
        else
            return null;
    }

    public List<Parts> GetRobotPartsFor(Enum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    public List<Parts> GetCarPartsFor(Enum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}
```
# Front-end Code Challenges

## Question 1
Given the below code snippet, solve the problems that follow:

```html
<div id="firstDiv" class="red-card">
<div id="secondDiv" class="red-card">

<style>
    #secondDiv {
        background: orange;
    }

    div {
        height: 150px;
        width: 150px;
        background: green;
    }

    .red-card {
        background: red;
    }

    .yellow-card {
        background: yellow;
    }
</style>
```

1. What will the colour of both div elements be?
2. How would you dynamically target ```firstDiv``` and make it's colour pink? (provide the code snippet)
3. How would you dynamically target ```secondDiv``` and add the ```yellow-card``` class to its class list? (provide the code snippet)

## Question 2
Consider the ```compareIt``` function definition

```javascript
function compareIt(num1, num2) {
    return num1 == num2;
}

compareIt(5, "5");
```

1. Why will the function call return true? 
2. How could one change this function so that data types are checked as well as values?

## Question 3
1. How would you make a web page mobile friendly (i.e responsive)? 
   * Provide examples of this.
2. What is the benefit of bundling .js scripts into one file? 
3. What needs to be done to ensure the browser understands Sass styling?
4. What should be done to ensure browser compatibility with newer flavours of JavaScript like ES6/7?
