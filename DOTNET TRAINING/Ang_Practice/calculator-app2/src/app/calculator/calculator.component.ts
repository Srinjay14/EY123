import { Component } from '@angular/core';

@Component({
  selector: 'app-calculator',
  standalone: true,
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  currentValue: string = '';

  appendToExpression(value: string) {
    this.currentValue += value;
  }

  calculate() {
    try {
      this.currentValue = eval(this.currentValue);
    } catch (e) {
      this.currentValue = 'Error';
    }
  }

  clear() {
    this.currentValue = '';
  }
}