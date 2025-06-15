// tests/throttle.test.js

const throttle = require('../src/throttle');

jest.useFakeTimers();

describe('Throttle Function', () => {
  it('should call function immediately', () => {
    const func = jest.fn();
    const throttled = throttle(func, 1000);

    throttled();
    expect(func).toBeCalledTimes(1);
  });

  it('should ignore calls within the limit', () => {
    const func = jest.fn();
    const throttled = throttle(func, 1000);

    throttled();
    throttled();
    throttled();

    expect(func).toBeCalledTimes(1);

    jest.advanceTimersByTime(1000);
    throttled();
    expect(func).toBeCalledTimes(2);
  });
});
