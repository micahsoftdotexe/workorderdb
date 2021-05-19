
function makenewcustomer(id, FirstName, LastName){
    var newnode = document.getElementById("c-1").cloneNode(true);
    newnode.id = "c"+"id"
    newnode.childNodes.item("first-1").innerText = FirstName;
    newnode.childNodes.item("first-1").id = "first"+id;
    newnode.childNodes.item("first-2").innerText = LastName;
    newnode.childNodes.item("first-2").id = "last"+id;
    newnode.childNodes.item("cid-1").innerText = id;
    newnode.childNodes.item("cid-1").id = "cid"+id;
    newnode.childNodes.item("csel-1").id = "csel" + id;
    return newnode;
}

function searchcustomer(){
    //delete all previous seach results
    var children = document.getElementById("customerTable").children[0].children;
    for(var i = 0; i < children.length; i++){
        if(children[i].id != "cheader" || children[i].id != "c-1"){
            //console.log(children[i]);
            console.log("ID:"+children[i].id)
            children[i].remove();
        }
    }
    var nameel = document.getElementById("customer").value;
    var data = {
        'name': nameel
    }
    var json = JSON.stringify(data)
    const xhr = new XMLHttpRequest()
    
    xhr.addEventListener('readystatechange',function(){
        if(this.readyState === this.DONE){
            //console.log(this.responseText);
            var response = this.responseText;
            for(var i = 0; i < response.recordset.length;i++){
                var newnode = makenewcustomer(response.recordset[i].CustomerID,response.recordset[i].FirstName,response.recordset[i].LastName);
                document.getElementById("customerTable").appendChild(newnode);
            }

        }
    })
    // console.log(json);
    xhr.open('POST','http://localhost:8080/customersearch',true)
    xhr.setRequestHeader('content-type', 'application/json')
    
    xhr.send(json);
   
}