import { Component, OnInit } from '@angular/core';
import { IEntry } from '../../components/entry-list/entry-list.component';

@Component({
  selector: 'app-entry-detail',
  templateUrl: './entry-detail.component.html',
  styleUrls: ['./entry-detail.component.css']
})
export class EntryDetailComponent implements OnInit {
  public entry! : IEntry

  constructor() { }

  ngOnInit(): void {
    this.entry = {
      title : "test",
      detail : "test2",
      author : "JOHN",
      date : "12/10/2022"
    }
  }

}
