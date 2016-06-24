function setAge(person, age){
    if (!person)
        return false;
    var result = age >= 0 && age < 100;
    if (result){
        person.age = age;
    }
    return result;
}