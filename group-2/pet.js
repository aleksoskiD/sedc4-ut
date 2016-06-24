function Pet (name, age){
    this.name = name || "";
    this.age = age | 0;

    this.isAlive = this.age < 20;
    this.isBaby = this.age < 2;

    this.haveBirthday = function(){
        this.age+=1;
        this.isAlive = this.age < 20;
        this.isBaby = this.age < 2;
    };
}