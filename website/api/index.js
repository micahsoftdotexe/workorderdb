var express = require("express");
//Initializing connection string
const dbConfig = {
    user:  'SA',
    password: 'DBProjectPass!',
    server: 'localhost',
    database: 'WorkorderDB',
    options:{
        encrypt: false
    }
};

//var bodyParser = require("body-parser");
const sql = require("mssql");
const cors = require('cors');
const bodyParser  = require('body-parser');
const app = express(); 

app.use(express.json());
app.use(express.urlencoded({ extended: true })); //Parse URL-encoded bodies
app.use(bodyParser.json());
app.use(cors());




app.post("/customersearch", function(req , res){
    console.log(req.body);
    var name = req.body.name;
    console.log(name)
	sql.connect(dbConfig).then(function(){
        const request = new sql.Request();
        request.query('SELECT * FROM Customer WHERE CONCAT(CONCAT(Customer.FirstName, \' \'), Customer.LastName) LIKE \'%' + name + '%\'', (err, result) => {
        console.log(result);
        res.send(result);
        })
    })
    // console.log(req.body);
    // res.send(req.body);
});

//Setting up server
 const server = app.listen(process.env.PORT || 8080, function () {
    const port = server.address().port;
    console.log("App now running on port", port);
 });