import { Component, OnInit, Input } from '@angular/core';
import { IEntry } from '../entry-list/entry-list.component';

@Component({
  selector: 'app-entry',
  templateUrl: './entry.component.html',
  styleUrls: ['./entry.component.css']
})
export class EntryComponent implements OnInit {

  @Input() entry!: IEntry;
  @Input() isComment! : boolean;

  constructor() { }

  ngOnInit(): void {
  }

}
