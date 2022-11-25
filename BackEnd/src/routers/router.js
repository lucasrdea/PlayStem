const express = require('express');
const router  = express.Router(); 
const auth = require('../middleware/auth');
const api = require('../api/api.js'); 

const use = fn =>(req, res, next)=>
    Promise.resolve(fn(req, res, next)).catch(next);

router.get('/', use(api.myGet)); 
router.get('/login', use(api.login)); 
router.get('/error', use(api.error)); 
router.get('/welcome',auth, use(api.welcome)); 
 
router.get("*", use((req, res) => {
    throw new Error("You reached a route that is not defined on this server");   
}));

module.exports = router;