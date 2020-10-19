using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model
{
    public enum default_primitives {  P }

    public List<Vector3> _vertices;
    public List<int> _index_list;
    public List<Vector2> _texture_coordinates;
    public List<int> _texture_index_list;
    public List<Vector3> _face_normals;

    public Model(default_primitives shape)
    {
        switch (shape)
        {
            case default_primitives.P:
                initialize_lists();
                add_p_vertices();
                add_texture_coordinates();
                add_indices_and_normals();


                break;
        }
    }




    private void add_texture_coordinates()
    {
        _texture_coordinates.Add(new Vector2(0.1f, 0.1f));
        _texture_coordinates.Add(new Vector2(0.5f, 0));
        _texture_coordinates.Add(new Vector2(0.9f, 0.1f));
        _texture_coordinates.Add(new Vector2(0, 0.5f));
        _texture_coordinates.Add(new Vector2(0.5f, 0.5f));
        _texture_coordinates.Add(new Vector2(1, 0.5f));
        _texture_coordinates.Add(new Vector2(0.1f, 0.9f));
        _texture_coordinates.Add(new Vector2(0.5f, 1));
        _texture_coordinates.Add(new Vector2(0.9f, 0.9f));
    }

    private void add_indices_and_normals()
    {
        _index_list.Add(0); _texture_index_list.Add(7);
        _index_list.Add(1); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(9); _texture_index_list.Add(3); // front 1

        _index_list.Add(1); _texture_index_list.Add(7);
        _index_list.Add(2); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(9); _texture_index_list.Add(3); // front 2

        _index_list.Add(2); _texture_index_list.Add(7);
        _index_list.Add(3); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(9); _texture_index_list.Add(3); // front 3

        _index_list.Add(4); _texture_index_list.Add(7);
        _index_list.Add(11); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(10); _texture_index_list.Add(3); // front 4

        _index_list.Add(4); _texture_index_list.Add(7);
        _index_list.Add(5); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(7); _texture_index_list.Add(3); // front 5

        _index_list.Add(5); _texture_index_list.Add(7);
        _index_list.Add(6); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(7); _texture_index_list.Add(3);// front 6

        _index_list.Add(7); _texture_index_list.Add(7);
        _index_list.Add(13); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(12); _texture_index_list.Add(3); // front 7

        _index_list.Add(7); _texture_index_list.Add(7);
        _index_list.Add(8); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(13); _texture_index_list.Add(3); // front 8

        _index_list.Add(7); _texture_index_list.Add(7);
        _index_list.Add(0); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(8); _texture_index_list.Add(3); // front 9

        _index_list.Add(0); _texture_index_list.Add(7);
        _index_list.Add(9); _texture_index_list.Add(6); _face_normals.Add(new Vector3(0, 0, -1));
        _index_list.Add(8); _texture_index_list.Add(3); // front 10



        _index_list.Add(15); _texture_index_list.Add(0);
        _index_list.Add(14); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(23); _texture_index_list.Add(3); // back 1

        _index_list.Add(16); _texture_index_list.Add(0);
        _index_list.Add(15); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(23); _texture_index_list.Add(3); // back 2

        _index_list.Add(17); _texture_index_list.Add(0);
        _index_list.Add(16); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(23); _texture_index_list.Add(3); // back 3

        _index_list.Add(24); _texture_index_list.Add(0);
        _index_list.Add(25); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(18); _texture_index_list.Add(3); // back 4

        _index_list.Add(18); _texture_index_list.Add(0);
        _index_list.Add(21); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(19); _texture_index_list.Add(3); // back 5

        _index_list.Add(19); _texture_index_list.Add(0);
        _index_list.Add(21); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(20); _texture_index_list.Add(3);// back 6

        _index_list.Add(26); _texture_index_list.Add(0);
        _index_list.Add(27); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(21); _texture_index_list.Add(3); // back 7

        _index_list.Add(21); _texture_index_list.Add(0);
        _index_list.Add(27); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(22); _texture_index_list.Add(3); // back 8

        _index_list.Add(22); _texture_index_list.Add(0);
        _index_list.Add(14); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(21); _texture_index_list.Add(3); // back 9

        _index_list.Add(22); _texture_index_list.Add(0);
        _index_list.Add(23); _texture_index_list.Add(1); _face_normals.Add(new Vector3(0, 0, 1));
        _index_list.Add(14); _texture_index_list.Add(3); // back 10



        _index_list.Add(0); _texture_index_list.Add(1);
        _index_list.Add(14); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(1); _texture_index_list.Add(5); // side 1 1 (facing top)
        _index_list.Add(14); _texture_index_list.Add(1);
        _index_list.Add(15); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(1); _texture_index_list.Add(5); // side 1 2

        _index_list.Add(1); _texture_index_list.Add(1);
        _index_list.Add(15); _texture_index_list.Add(2); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(2); _texture_index_list.Add(5); // side 2 1 (facing left)
        _index_list.Add(2); _texture_index_list.Add(1);
        _index_list.Add(15); _texture_index_list.Add(2); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(16); _texture_index_list.Add(5); // side 2 2

        _index_list.Add(3); _texture_index_list.Add(1);
        _index_list.Add(2); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(16); _texture_index_list.Add(5); // side 3 1 (facing bot)
        _index_list.Add(3); _texture_index_list.Add(1);
        _index_list.Add(16); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(17); _texture_index_list.Add(5);// side 3 2

        _index_list.Add(4); _texture_index_list.Add(1);
        _index_list.Add(3); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(18); _texture_index_list.Add(5); // side 4 1 (facing right)
        _index_list.Add(18); _texture_index_list.Add(1);
        _index_list.Add(3); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(17); _texture_index_list.Add(5); // side 4 2

        _index_list.Add(5); _texture_index_list.Add(1);
        _index_list.Add(4); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(18); _texture_index_list.Add(5); // side 5 1 (facing bot 2)
        _index_list.Add(5); _texture_index_list.Add(1);
        _index_list.Add(18); _texture_index_list.Add(2); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(19); _texture_index_list.Add(5); // side 5 2

        _index_list.Add(6); _texture_index_list.Add(1);
        _index_list.Add(5); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, -1, 0).normalized);
        _index_list.Add(20); _texture_index_list.Add(5); // side 6 1 (facing bot right)
        _index_list.Add(5); _texture_index_list.Add(1);
        _index_list.Add(19); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, -1, 0));
        _index_list.Add(20); _texture_index_list.Add(5); // side 6 2

        _index_list.Add(7); _texture_index_list.Add(1);
        _index_list.Add(6); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(21); _texture_index_list.Add(5); // side  7 1 (facing right 2)
        _index_list.Add(21); _texture_index_list.Add(1);
        _index_list.Add(6); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(20); _texture_index_list.Add(5);// side 7 2

        _index_list.Add(0); _texture_index_list.Add(1);
        _index_list.Add(7); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 1, 0));
        _index_list.Add(14); _texture_index_list.Add(5); // side 8 1 (facing top right)
        _index_list.Add(7); _texture_index_list.Add(1);
        _index_list.Add(21); _texture_index_list.Add(2); _face_normals.Add(new Vector3(1, 1, 0));
        _index_list.Add(14); _texture_index_list.Add(5); // side 8 2



        _index_list.Add(8); _texture_index_list.Add(5);
        _index_list.Add(9); _texture_index_list.Add(8); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(23); _texture_index_list.Add(7); // inside 1 1 (facing bot)
        _index_list.Add(8); _texture_index_list.Add(5);
        _index_list.Add(23); _texture_index_list.Add(8); _face_normals.Add(new Vector3(0, -1, 0));
        _index_list.Add(22); _texture_index_list.Add(7); // inside 1 2

        _index_list.Add(9); _texture_index_list.Add(5);
        _index_list.Add(10); _texture_index_list.Add(8); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(23); _texture_index_list.Add(7); // inside 2 1 (facing right)
        _index_list.Add(23); _texture_index_list.Add(5);
        _index_list.Add(10); _texture_index_list.Add(8); _face_normals.Add(new Vector3(1, 0, 0));
        _index_list.Add(24); _texture_index_list.Add(7); // inside 2 2

        _index_list.Add(10); _texture_index_list.Add(5);
        _index_list.Add(11); _texture_index_list.Add(8); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(25); _texture_index_list.Add(7); // inside 3 1 (facing top)
        _index_list.Add(25); _texture_index_list.Add(5);
        _index_list.Add(24); _texture_index_list.Add(8); _face_normals.Add(new Vector3(0, 1, 0));
        _index_list.Add(10); _texture_index_list.Add(7);// inside 3 2

        _index_list.Add(11); _texture_index_list.Add(5);
        _index_list.Add(12); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, 1, 0));
        _index_list.Add(26); _texture_index_list.Add(7); // inside 4 1 (facing top left)
        _index_list.Add(26); _texture_index_list.Add(5);
        _index_list.Add(25); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, 1, 0));
        _index_list.Add(11); _texture_index_list.Add(7); // inside 4 2

        _index_list.Add(12); _texture_index_list.Add(5);
        _index_list.Add(13); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(26); _texture_index_list.Add(7); // inside 5 1 (facing left)
        _index_list.Add(26); _texture_index_list.Add(5);
        _index_list.Add(13); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, 0, 0));
        _index_list.Add(27); _texture_index_list.Add(7); // inside 5 2

        _index_list.Add(13); _texture_index_list.Add(5);
        _index_list.Add(8); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, -1, 0));
        _index_list.Add(22); _texture_index_list.Add(7); // inside 6 1 (facing bot left)
        _index_list.Add(22); _texture_index_list.Add(5);
        _index_list.Add(27); _texture_index_list.Add(8); _face_normals.Add(new Vector3(-1, -1, 0));
        _index_list.Add(13); _texture_index_list.Add(7); // inside 6 2
    }

    private void add_p_vertices()
    {
        _vertices.Add(new Vector3(0.2f, 0.5f, 0.2f));
        _vertices.Add(new Vector3(-0.2f, 0.5f, 0.2f));
        _vertices.Add(new Vector3(-0.2f, -0.5f, 0.2f));
        _vertices.Add(new Vector3(0, -0.5f, 0.2f));
        _vertices.Add(new Vector3(0, -0.1f, 0.2f));
        _vertices.Add(new Vector3(0.2f, -0.1f, 0.2f));
        _vertices.Add(new Vector3(0.4f, 0.1f, 0.2f));
        _vertices.Add(new Vector3(0.4f, 0.3f, 0.2f));
        _vertices.Add(new Vector3(0.15f, 0.35f, 0.2f));
        _vertices.Add(new Vector3(0, 0.35f, 0.2f));
        _vertices.Add(new Vector3(0, 0.05f, 0.2f));
        _vertices.Add(new Vector3(0.15f, 0.05f, 0.2f));
        _vertices.Add(new Vector3(0.25f, 0.15f, 0.2f));
        _vertices.Add(new Vector3(0.25f, 0.25f, 0.2f));

        _vertices.Add(new Vector3(0.2f, 0.5f, -0.2f));
        _vertices.Add(new Vector3(-0.2f, 0.5f, -0.2f));
        _vertices.Add(new Vector3(-0.2f, -0.5f, -0.2f));
        _vertices.Add(new Vector3(0, -0.5f, -0.2f));
        _vertices.Add(new Vector3(0, -0.1f, -0.2f));
        _vertices.Add(new Vector3(0.2f, -0.1f, -0.2f));
        _vertices.Add(new Vector3(0.4f, 0.1f, -0.2f));
        _vertices.Add(new Vector3(0.4f, 0.3f, -0.2f));
        _vertices.Add(new Vector3(0.15f, 0.35f, -0.2f));
        _vertices.Add(new Vector3(0, 0.35f, -0.2f));
        _vertices.Add(new Vector3(0, 0.05f, -0.2f));
        _vertices.Add(new Vector3(0.15f, 0.05f, -0.2f));
        _vertices.Add(new Vector3(0.25f, 0.15f, -0.2f));
        _vertices.Add(new Vector3(0.25f, 0.25f, -0.2f));
    }

    private void initialize_lists()
    {
        _vertices = new List<Vector3>();
        _index_list = new List<int>();
        _texture_coordinates = new List<Vector2>();
        _texture_index_list = new List<int>();
        _face_normals = new List<Vector3>();
    }
}
