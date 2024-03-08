function sort(collection, comparer) {
  let isSorted = false;
  do {
    isSorted = false;
    for (let i = 0; i < collection.length - 1; i++) {
      if (comparer(collection[i], collection[i + 1]) > 0) {
        let itemCache = collection[i];
        collection[i] = collection[i + 1];
        collection[i + 1] = itemCache;
        isSorted = true;
      }
    }
  } while (isSorted);
}

let collection = [1, 2, 3];
sort(collection, (item1, item2) => {
  if (item1 > item2) {
    return 1;
  } else {
    return 0;
  }
});
console.log(collection);
