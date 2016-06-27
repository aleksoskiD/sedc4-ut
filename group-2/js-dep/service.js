var personService = (function(){
    var persons = [{
        id: 1,
        name: "Wekoslav",
        lastName: "Stefanovski"
    }];


    var getPersonById = function(id){
        var result = persons.filter((item)=>item.id===id);
        if (result.length){
            alert("Getting person by id success");   
            return {
                success: true,
                data: result[0]
            };
        } else {
            alert("Getting person by id failure");   
            return {success: false}
        }
    } 

    return {
        getPersonById : getPersonById
    }
})();