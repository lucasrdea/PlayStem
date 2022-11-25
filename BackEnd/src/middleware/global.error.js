function errorHandler (error, req, res, next) {
  console.log("error handling still happening");
  res.header("Content-Type", 'application/json');

  const status = error.status || 400
  res.status(status).send(error.message)
}

module.exports = errorHandler;
