import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { selectItemsArray } from '../../state';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent {

  item$ = this.store.select(selectItemsArray)
  constructor(private store: Store) { }
}
