QUnit.test("testing valid object with valid age", function(assert){
    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = 0x26;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, age);
    assert.ok(result);
});

QUnit.test("testing valid object with negative age", function(assert){
    //arrange
    var person = {name : "Wekoslav", age:20};
    var age = -20;

    //act
    var result = setAge(person, age);

    //assert
    assert.equal(person.age, 20);
    assert.notOk(result);
});