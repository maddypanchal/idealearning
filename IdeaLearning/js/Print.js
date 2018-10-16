function printData() {
   
    var divToPrint = document.getElementById("printdata");
    newWin = window.open("");
    newWin.document.write(divToPrint.outerHTML);
    newWin.print();
    newWin.close();

}