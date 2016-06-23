QUnit.test("constuctor valid test", function(assert){
    var name = "Rex";
    var age = 12;

    var rex = new Pet(name, age);

    assert.equal(rex.name, name);
    assert.equal(rex.age, age);
    assert.equal(rex.isAlive, true);
    assert.equal(rex.isBaby, false);
});

QUnit.test("constuctor valid test", function(assert){
    var name = "Rex";
    var age = 12;

    var rex = new Pet(name, age);

    assert.equal(rex.name, name);
    assert.equal(rex.age, age);
    assert.equal(rex.isAlive, true);
    assert.equal(rex.isBaby, false);
});

QUnit.test("constuctor no age test", function(assert){
    var name = "Rex";

    var rex = new Pet(name);

    assert.equal(rex.name, name);
    assert.equal(rex.age, 0);
    assert.equal(rex.isAlive, true);
    assert.equal(rex.isBaby, true);
});

QUnit.test("constuctor string age test", function(assert){
    var name = "Rex";
    var age = "10";

    var rex = new Pet(name, age);

    assert.equal(rex.name, name);
    assert.strictEqual(rex.age, 10);
});

QUnit.test("constuctor no params test", function(assert){
    var rex = new Pet();

    assert.equal(rex.name, "");
    assert.strictEqual(rex.age, 0);
});

QUnit.test("have birthday test (regular)", function(assert){
    var rex = new Pet("Rex", 10);

    rex.haveBirthday();

    assert.equal(rex.age, 11);
    assert.equal(rex.isAlive, true);
});

QUnit.test("have birthday test (baby to adult)", function(assert){
    var rex = new Pet("Rex", 1);

    rex.haveBirthday();

    assert.equal(rex.age, 2);
    assert.equal(rex.isAlive, true);
    assert.equal(rex.isBaby, false);
});

QUnit.test("have birthday test (alive to dead)", function(assert){
    var rex = new Pet("Rex",19);

    rex.haveBirthday();

    assert.equal(rex.age, 20);
    assert.equal(rex.isAlive, false);
});




