// tests/debounce.test.js

const debounce = require('../src/debounce');

jest.useFakeTimers();

describe('Debounce Function', () => {
  it('should call the function after the delay', () => {
    const func = jest.fn();
    const debounced = debounce(func, 1000);

    debounced();
    expect(func).not.toBeCalled();

    jest.advanceTimersByTime(1000);
    expect(func).toBeCalledTimes(1);
  });

  it('should reset timer if called multiple times within delay', () => {
    const func = jest.fn();
    const debounced = debounce(func, 1000);

    debounced();
    jest.advanceTimersByTime(500);
    debounced();
    jest.advanceTimersByTime(500);
    debounced();
    jest.advanceTimersByTime(999);

    expect(func).not.toBeCalled();

    jest.advanceTimersByTime(1);
    expect(func).toBeCalledTimes(1);
  });
});
