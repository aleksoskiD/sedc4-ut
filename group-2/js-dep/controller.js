var personController = (function(){
    var data = {
        currentPerson : null,
        errorState: false,
    };

    var getPerson = function (id) {
        if (typeof id !== "number")
            return;
        var result = personService.getPersonById(id);
        if (result && result.success){
            data.currentPerson = result.data;
            data.errorState = false;
        } else {
            data.errorState = true;
        }
    };

    return { 
        getPerson : getPerson,
        data: data
    };
})();