function setAge(person, age){
    if (typeof age !== "number")
        return false;

    age = age | 0;

    if (age >= 100 || age < 0)
        return false;

    if (!person.hasOwnProperty('age'))
        return false;

    person.age = age;
    return true;
}