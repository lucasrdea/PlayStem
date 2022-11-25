const jwt = require("jsonwebtoken");

const dotenv = require('dotenv');
dotenv.config();

const config = process.env;

const verifyToken = (req, res, next) => {
  const header = req.body.token || req.query.token || req.headers.authorization;
  var token = header.split(/\s+/).pop() || '';

  console.log("token", token)
    
  if (!token) {
    return res.status(403).send("A token is required for authentication");
  }
  try {
    const decoded = jwt.verify(token, config.TOKEN_KEY);
    req.user = decoded;
  } catch (err) {
    return res.status(401).send("Invalid Token");
  }
  return next();
};

module.exports = verifyToken;