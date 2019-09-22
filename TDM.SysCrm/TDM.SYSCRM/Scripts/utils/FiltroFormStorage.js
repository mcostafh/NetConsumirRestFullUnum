function loadFilter(id) {
    var inputSaveds = JSON.parse(localStorage.getItem(id));
    if (!inputSaveds)
        return;

    $(`${id} :input`).each(function (i) {
        var inputForm = $(this)[0];
        var inputSaved = inputSaveds.filter((x) => x.name === inputForm.name)[0];
        if (!!inputSaved)
            inputForm.value = inputSaved.value;
    });
    $("#filtrarBtn").click();
}

function saveFilter(id) {
    var form = $(id);
    form.submit(function (event) {
        var inputs = JSON.stringify(form.serializeArray());
        localStorage.setItem(id, inputs);
    });
}