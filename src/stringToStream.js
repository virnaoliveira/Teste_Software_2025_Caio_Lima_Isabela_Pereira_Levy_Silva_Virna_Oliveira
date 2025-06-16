const { Readable } = require('stream');

function stringToStream(text) {
  return Readable.from([text]);
}

module.exports = { stringToStream };
