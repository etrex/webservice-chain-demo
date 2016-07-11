function debug() {
  var Result = doGet(
    {
        "number": "5566",
        "name": "etrex",
        "score": "87"
    }
  );
  Logger.log("Result: %s" , Result);
}