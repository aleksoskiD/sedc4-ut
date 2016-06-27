var personController = (function(){
    var currentPerson = null;
    var errorState = false;

    var getPerson = function(id){
        var result = personService.getPerson(id);
        if (result.success){
            currentPerson = result.data;
        } else {
            currentPerson = null;
        }
        errorState = !result.success;
    } 

    return {
        getPerson : getPerson,
        currentPerson : currentPerson,
        errorState: errorState
    }
});
