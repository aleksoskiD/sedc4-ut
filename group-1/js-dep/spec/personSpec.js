describe("tests for controller", function(){
    it("person controller manages successfull return from service", function(){
        //arrange
        spyOn(personService,"getPersonById").and.returnValue({
                success:true,
                data: "Weko was here"
        });

        //act
        personController.getPerson();

        //expect
        expect(personController.data.currentPerson).toBe("Weko was here");
        expect(personController.data.errorState).toBeFalsy();
    })

    it("person controller manages failed return from service", function(){
        //arrange
        var personId = 2;

        //act
        personController.getPerson(personId);

        //expect
        expect(personController.data.currentPerson).toBe(null);
        expect(personController.data.errorState).toBeTruthy();
    })

    it("test that integer one does not equal to string one", function(){
        //arrange

        //act
        var result = 1 === "1";

        //assert
        expect(result).toBeFalsy();
    });

    it("test that integer one is equal to string one", function(){
        //arrange

        //act
        var result = 1 == "1";

        //assert
        expect(result).toBeTruthy();
    });
})

describe("tests for service", function(){
    it("test that integer one does not equal to string one", function(){
        //arrange

        //act
        var result = 1 === "1";

        //assert
        expect(result).toBeFalsy();
    });

    it("test that integer one is equal to string one", function(){
        //arrange

        //act
        var result = 1 == "1";

        //assert
        expect(result).toBeTruthy();
    });
})