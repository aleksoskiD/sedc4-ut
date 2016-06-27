describe("demo tests", function(){
    it("should equal integer one with string one", function(){
        //arrange

        //act
        var result = 1 == "1";

        //assert
        expect(result).not.toBeFalsy();
    });

    it("should not equal integer one with string one", function(){
        //arrange

        //act
        var result = 1 === "1";

        //assert
        expect(result).toBeFalsy();
    });
})

describe("controller tests", function(){
    it("getPerson should handle success response", function(){
        //arrange
        var personId = 1;
        spyOn(personService,"getPersonById").and.returnValue({
            success : true,
            data : "Weko was here" 
        });

        //act
        personController.getPerson(personId);

        //assert
        expect(personController.data.currentPerson).toBe("Weko was here");
        expect(personController.data.errorState).toBeFalsy();
        expect(personService.getPersonById).toHaveBeenCalledWith(personId);
    });

    it("getPerson should handle failure response", function(){
        //arrange
        var personId = 2;
        //act
        personController.getPerson(personId);

        //assert
        expect(personController.data.currentPerson).toBe(null);
        expect(personController.data.errorState).toBe(true);
    });
})


