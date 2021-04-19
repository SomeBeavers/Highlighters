// Create an object:
var person = {
    firstName: "John",
    lastName: "Doe",
    id: 5566,
    fullName: function () {
        a1:Integer = 1;
        return this.firstName + " " + this.lastName;
    }
};
// Display data from the object:
document.getElementById("demo").innerHTML = person.fullName();