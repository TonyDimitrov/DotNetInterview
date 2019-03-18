// Write your JavaScript code.

$(document).ready(function () {
    $('.datepicker').datepicker({
        format: 'dd-mm-yyyy',
    });
});

var num = 1;
document.getElementById('addbutton').addEventListener("click", addInput);
function addInput() {
    var newElement = `<div class="form-group" id="demo">
        <label type="text" class="control-label">Question Content</label>
        <input type="text" name="Questions[${num}].Content" value class="form-control" placeholder="*" />
    </div>`
    document.getElementById('addfield').innerHTML += newElement;
    num++;
}