const express = require('express');
const app = express();
const bodyParser = require('body-parser');
const port = process.env.PORT || 3000;
const router = require('./routers/router.js');
const errorHandler = require('./middleware/global.error');

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({ extended: false }));
app.use(express.json({ limit: "50mb" }));
app.use('/api/', router);
app.use(errorHandler);
app.use("*", (req, res) => {
    res.status(404).json({
      success: "false",
      message: "Page not found",
      error: {
        statusCode: 404,
        message: "You reached a route that is not defined on this server",
      },
    });
});

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})
