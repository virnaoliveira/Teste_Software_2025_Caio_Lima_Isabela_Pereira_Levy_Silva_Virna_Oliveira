const { stringToStream } = require('../src/stringToStream');

describe('stringToStream', () => {
  it('should return a readable stream from a string', async () => {
    const input = 'Olá, mundo!';
    const stream = stringToStream(input);

    let data = '';
    for await (const chunk of stream) {
      data += chunk;
    }

    expect(data).toBe(input);
  });

  it('should emit "data" event with correct content', (done) => {
    const input = 'Teste de evento';
    const stream = stringToStream(input);

    let result = '';
    stream.on('data', (chunk) => {
      result += chunk;
    });

    stream.on('end', () => {
      expect(result).toBe(input);
      done();
    });
  });
});
