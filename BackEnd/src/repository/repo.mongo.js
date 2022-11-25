const mongoose = require('mongoose');
var uri = 'mongodb+srv://lucasrdea:4u0uU8rS99KMZ97oeo1322oBKitwekHHTuwSgjEgR6uMaHgj@atlascluster.8tponve.mongodb.net/PlayStem';

module.exports = async () => {
    await mongoose.connect(uri, {
         useNewUrlParser: true, 
         useUnifiedTopology: true
    });

    return mongoose;
}