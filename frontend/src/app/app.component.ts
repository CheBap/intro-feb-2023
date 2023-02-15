import { Component } from '@angular/core';
import { selectCounterCurrent } from './state';
import { counterEvents } from './state/actions/counter.actions';
import { Store } from "@ngrx/store";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Learning Resources Application';
  current$ = this.store.select(selectCounterCurrent);
  constructor(private store: Store) {

    this.store.dispatch(counterEvents.counterEntered())
  }
}

