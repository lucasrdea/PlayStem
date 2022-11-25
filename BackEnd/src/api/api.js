
const repoMongo = require('../repository/repo.mongo');
const userSchema = require('../repository/schema/playstem.schema');
const jwt = require("jsonwebtoken");
const dotenv = require('dotenv');

dotenv.config();

const { TOKEN_KEY } = process.env;

const myGet = async (req, res) => {
    await repoMongo().then(async (mongoose) => {
        try{
            console.log('connected to mongoDB');    
            const user = {
                id:  '1263'
            };
            await new userSchema(user).save();

        }finally{
            mongoose.connection.close()
        }
    })
    res.send("working");
}; 

const login = async (req, res) => {    
    const token = jwt.sign(
        { user_id: 132 },
        TOKEN_KEY,
        {
          expiresIn: "2h",
        }
      );
    res.status(200).send(token);
}; 

const welcome = (req, res) =>{
    res.status(200).send("Welcome 🙌 ");
}

const error =  (req, res) => {    
    throw new Error("some error");
}; 
 
module.exports = {myGet, login, welcome, error};