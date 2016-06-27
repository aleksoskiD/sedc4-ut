var personController = (function(){
    var data = {
        currentPerson : null,
        errorState: false,
    };

    var getPerson = function (id) {
        var result = personService.getPersonById(id);
        if (result && result.success){
            data.currentPerson = result.data;
            data.errorState = false;
        } else {
            data.currentPerson = null;
            data.errorState = true;
        }
    };

    return { 
        getPerson : getPerson,
        data: data
    };
})();