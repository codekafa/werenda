

// document ready for werenda layout

$(document).ready(function () {



});




// global methods for werenda layout

function FormCreateSerializer(formName) {
    var myform = $('#' + formName);
    var disabled = myform.find(':input:disabled').removeAttr('disabled');
    var array = new Array();

    var inputs = $("#" + formName + " *[data-serialize='true']");

    for (var i = 0; i < inputs.length; i++) {
        var value = inputs.eq(i).val();
        if (inputs.eq(i).data('maskinput') == undefined) {
            array.push({ name: inputs.eq(i).attr('id'), value: inputs.eq(i).val() });
        } else {
            array.push({ name: inputs.eq(i).attr('id'), value: inputs.eq(i).cleanVal() })
        }
    }

    //$("#" + formName + " *[data-serialize='true']").serializeArray();
    disabled.attr('disabled', 'disabled');

    var data = new Object();
    for (var a = 0; a < array.length; a++) {
        data[array[a].name] = array[a].value;
    }
    return data;
}