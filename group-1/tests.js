QUnit.test("testing valid object with valid age - success", function(assert){
    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 0x26;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, age);
    assert.ok(result);
});

QUnit.test("testing valid object with negative age - failure", function(assert){
    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = -22;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with large age - failure", function(assert){
    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 414;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with zero age - success", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 0;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, age);
    assert.ok(result);
});

QUnit.test("testing valid object with ninety-nine age - success", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 99;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, age);
    assert.ok(result);
});

QUnit.test("testing valid object with hundred age - failure", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 100;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with invalid age (string) - failure", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = "dvajs pet";

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with invalid age (array) - failure", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = ["dvajs pet", "dvajs dva"];

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with invalid age (object) - failure", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = { one: "dvajs pet", two: "dvajs dva"};

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});

QUnit.test("testing valid object with invalid age (decimal) - success", function(assert){

    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 38.5;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 38);
    assert.ok(result);
});
