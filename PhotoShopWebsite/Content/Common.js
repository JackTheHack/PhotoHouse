function createHidden(id, name, value) {
    var hiddenField = document.createElement("input");
    hiddenField.setAttribute("id", id);
    hiddenField.setAttribute("name", name);
    hiddenField.setAttribute("type", "hidden");
    hiddenField.setAttribute("value", value);
    return hiddenField;
}

