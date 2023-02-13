import { StringCalculator } from "./string-calculator";

describe('String Calculator', () => {
    it('Empty String Returns Zero', () => {
        const calculator = new StringCalculator();

        let result = calculator.add("");
        expect(result).toEqual(0);
    });

});