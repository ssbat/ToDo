const PROXY_CONFIG = {
  "/api": {
    target: "https://localhost:7103",
    secure: false,
    pathRewrite: {
      "^/api": ""
    }
  }
};

module.exports = PROXY_CONFIG;
